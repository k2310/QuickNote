using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.Runtime.InteropServices;   //GuidAttribute
using System.Reflection;                //Assembly
using System.Threading;                 //Mutex
using System.Security.AccessControl;    //MutexAccessRule
using System.Security.Principal;        //SecurityIdentifier


namespace QuickNote
{

    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {

            // get application GUID as defined in AssemblyInfo.cs
            string appGuid = ((GuidAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(GuidAttribute), false).GetValue(0)).Value.ToString();
            // unique id for global mutex - Global prefix means it is global to the machine
            string mutexId = string.Format("Global\\{{{0}}}", appGuid);

            using (var mutex = new Mutex(false, mutexId))
            {
                // edited by Jeremy Wiebe to add example of setting up security for multi-user usage
                // edited by 'Marc' to work also on localized systems (don't use just "Everyone") 
                var allowEveryoneRule = new MutexAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), MutexRights.FullControl, AccessControlType.Allow);
                var securitySettings = new MutexSecurity();
                securitySettings.AddAccessRule(allowEveryoneRule);
                mutex.SetAccessControl(securitySettings);

                // edited by acidzombie24
                var hasHandle = false;
                try
                {
                    try
                    {
                        // note, you may want to time out here instead of waiting forever
                        // edited by acidzombie24
                        // mutex.WaitOne(Timeout.Infinite, false);
                        hasHandle = mutex.WaitOne(0, false);
                        if (hasHandle == false)
                        {
                          // WaitOne メソッドで所有権を取得できなかった場合の処理です。
                          if (!WakeupWindow()) {
                            // ウィンドウを前面に出すのに失敗した場合は、メッセージで通知しておくことにします。
                            MessageBox.Show("アプリケーションは既に起動しています。");
                          }
                            return;
                        }
                            // throw new TimeoutException("Timeout waiting for exclusive access");
                    }
                    catch (AbandonedMutexException)
                    {
                        // Log the fact the mutex was abandoned in another process, it will still get aquired
                        hasHandle = true;
                    }

                    // Perform your work here.
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1());

                }
                finally
                {
                    // edited by acidzombie24, added if statemnet
                    if (hasHandle)
                        mutex.ReleaseMutex();
                }


            }


        }





        /// <summary>
        /// プロセス名とプログラム名が同一のプロセスを見つけ、
        /// それが所持しているメインウィンドウを前面に表示します。
        /// </summary>
        /// <returns>正常にウィンドウを前面に表示できた場合に true を返します。</returns>
        /// <note>
        /// 「EZ-NET： アプリケーションの二重起動を防止する」 http://program.station.ez-net.jp/special/visual_studio/csharp/2005.mutex.asp
        /// </note>
        static bool WakeupWindow()
        {
            bool result;
            System.Diagnostics.Process current;
            System.Diagnostics.Process[] running;
            System.Diagnostics.Process target = null;

            // 現在アクティブなプロセスを取得します。
            current = System.Diagnostics.Process.GetCurrentProcess();
            // 稼働中のプロセスから、アクティブなプロセスと同一のプロセス名を持つプロセスを取得します。
            running = System.Diagnostics.Process.GetProcessesByName(current.ProcessName);

            // 自分自身を除外しつつ、自分以外の同一プログラムのプロセスを target に取得します。
            foreach (System.Diagnostics.Process proc in running)
            {
                // プロセス ID が自分自身とは異なるものを探します。
                if (proc.Id != current.Id)
                {
                    // 捜査中のプロセスが、アクティブなプロセスと同一ファイル名であるかどうかを調べます。
                    if (proc.MainModule.FileName == current.MainModule.FileName)
                    {
                        // ファイル名が一致した場合は、それが目的のプロセスとなります。
                        target = proc;
                        break;
                    }
                }
            }

            // 該当するプロセスが見つかった場合の操作です。
            if (target != null)
            {
                // ウィンドウが最小化されていた場合には、それを元に戻します。
                if (WindowsAPI.IsIconic(target.MainWindowHandle)) WindowsAPI.ShowWindowAsync(target.MainWindowHandle, WindowsAPI.ShowWindowEnum.SW_RESTORE);
                // ウィンドウを前面に移動します。
                result = WindowsAPI.SetForegroundWindow(target.MainWindowHandle);
            } else {
                // 該当するプロセスが見つからなかった場合には false を返させます。
                result = false;
            }

            return result;
        }
    }
}
