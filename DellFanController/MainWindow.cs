using System;
using System.Threading;
using System.Windows.Forms;

namespace DellFanController
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Login you into iDRAC using IPMI tool and set fan speed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string userName = UsernameInput.Text;
            string passWord = passwordInput.Text;
            string ipAddress = IdracIpAddressInput.Text;
            string speedValue = (FanSpeedTracker.Value * 10).ToString();

            ShellWorker.SendLoginToShell(userName, passWord, ipAddress, speedValue);
        }

        /// <summary>
        /// Closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseAppBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Save credentials into file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveCredentialsBtn_Click(object sender, EventArgs e)
        {
            string userName = UsernameInput.Text;
            string passWord = passwordInput.Text;
            string ipAddres = IdracIpAddressInput.Text;

            Config.ChangeValueOfKey("usernm", userName);
            Config.ChangeValueOfKey("passwd", passWord);
            Config.ChangeValueOfKey("ipaddr", ipAddres);
        }

        /// <summary>
        /// Loads the configuration at load the app.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAppStart(object sender, EventArgs e)
        {
            Config.Setup();

            string userName = Config.GetValue("usernm");
            string passWord = Config.GetValue("passwd");
            string ipAddres = Config.GetValue("ipaddr");

            if (!Config.IsEmpty(userName) && !Config.IsEmpty(passWord) && !Config.IsEmpty(ipAddres))
            {
                UsernameInput.Text = userName;
                passwordInput.Text = passWord;
                IdracIpAddressInput.Text = ipAddres;
            }
        }
    }
}
