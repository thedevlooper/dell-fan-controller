
using System.Diagnostics;
using System.Windows.Forms;

namespace DellFanController
{
    internal class ShellWorker
    {
        private static void SendShellInput(string rawInput)
        {
            Process shellProcess = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            shellProcess.Start();
            shellProcess.StandardInput.WriteLine(rawInput);
            shellProcess.Close();
        }

        /// <summary>
        /// Login into IPMI and send the command to set fans.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <param name="ipAddress"></param>
        /// <param name="value"></param>
        public static void SendLoginToShell(string userName, string passWord, string ipAddress, string value)
        {
            SendShellInput("ipmitool -I lanplus -H " + ipAddress + " -U " + userName + " -P " + passWord + " raw 0x30 0x30 0x02 0xff 0x" + value);
        }
    }
}
