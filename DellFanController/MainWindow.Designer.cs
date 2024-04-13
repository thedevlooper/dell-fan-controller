namespace DellFanController
{
    partial class MainWindow
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.LoginBtn = new System.Windows.Forms.Button();
            this.CloseAppBtn = new System.Windows.Forms.Button();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveCredentialsBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.IdracIpAddressInput = new System.Windows.Forms.MaskedTextBox();
            this.FanSpeedTracker = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FanSpeedTracker)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Location = new System.Drawing.Point(341, 278);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(114, 28);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "Login and Apply";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // CloseAppBtn
            // 
            this.CloseAppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseAppBtn.Location = new System.Drawing.Point(245, 278);
            this.CloseAppBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CloseAppBtn.Name = "CloseAppBtn";
            this.CloseAppBtn.Size = new System.Drawing.Size(88, 28);
            this.CloseAppBtn.TabIndex = 1;
            this.CloseAppBtn.Text = "Close";
            this.CloseAppBtn.UseVisualStyleBackColor = true;
            this.CloseAppBtn.Click += new System.EventHandler(this.CloseAppBtn_Click);
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(99, 32);
            this.UsernameInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(297, 23);
            this.UsernameInput.TabIndex = 2;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(99, 66);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(297, 23);
            this.passwordInput.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.FanSpeedTracker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.IdracIpAddressInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.UsernameInput);
            this.groupBox1.Controls.Add(this.passwordInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(442, 201);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login to iDRAC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(111, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dell servers fan controller";
            // 
            // SaveCredentialsBtn
            // 
            this.SaveCredentialsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveCredentialsBtn.Location = new System.Drawing.Point(13, 277);
            this.SaveCredentialsBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveCredentialsBtn.Name = "SaveCredentialsBtn";
            this.SaveCredentialsBtn.Size = new System.Drawing.Size(119, 28);
            this.SaveCredentialsBtn.TabIndex = 6;
            this.SaveCredentialsBtn.Text = "Save credentials";
            this.SaveCredentialsBtn.UseVisualStyleBackColor = true;
            this.SaveCredentialsBtn.Click += new System.EventHandler(this.SaveCredentialsBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "iDRAC IP:";
            // 
            // IdracIpAddressInput
            // 
            this.IdracIpAddressInput.Location = new System.Drawing.Point(99, 111);
            this.IdracIpAddressInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IdracIpAddressInput.Name = "IdracIpAddressInput";
            this.IdracIpAddressInput.Size = new System.Drawing.Size(297, 23);
            this.IdracIpAddressInput.TabIndex = 5;
            // 
            // FanSpeedTracker
            // 
            this.FanSpeedTracker.Location = new System.Drawing.Point(99, 149);
            this.FanSpeedTracker.Name = "FanSpeedTracker";
            this.FanSpeedTracker.Size = new System.Drawing.Size(297, 45);
            this.FanSpeedTracker.TabIndex = 7;
            this.FanSpeedTracker.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.FanSpeedTracker.Value = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fans speed:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 315);
            this.Controls.Add(this.SaveCredentialsBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CloseAppBtn);
            this.Controls.Add(this.LoginBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dell fan controller v1.0 by thedevlooper";
            this.Load += new System.EventHandler(this.OnAppStart);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FanSpeedTracker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button CloseAppBtn;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.MaskedTextBox passwordInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveCredentialsBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox IdracIpAddressInput;
        private System.Windows.Forms.TrackBar FanSpeedTracker;
        private System.Windows.Forms.Label label5;
    }
}

