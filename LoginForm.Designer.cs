namespace authorization
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.signInButton = new System.Windows.Forms.Button();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.userPic = new System.Windows.Forms.PictureBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.taskbarPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.goToRegistration = new System.Windows.Forms.Label();
            this.backgroundPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.taskbarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.Controls.Add(this.footerPanel);
            this.backgroundPanel.Controls.Add(this.mainPanel);
            this.backgroundPanel.Controls.Add(this.headerPanel);
            this.backgroundPanel.Controls.Add(this.taskbarPanel);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(500, 600);
            this.backgroundPanel.TabIndex = 0;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.Lavender;
            this.footerPanel.Controls.Add(this.goToRegistration);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 560);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(500, 40);
            this.footerPanel.TabIndex = 3;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPanel.Controls.Add(this.signInButton);
            this.mainPanel.Controls.Add(this.showPass);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.passField);
            this.mainPanel.Controls.Add(this.userPic);
            this.mainPanel.Controls.Add(this.loginField);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(0, 160);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(500, 400);
            this.mainPanel.TabIndex = 2;
            // 
            // signInButton
            // 
            this.signInButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.signInButton.FlatAppearance.BorderSize = 3;
            this.signInButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.signInButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInButton.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.Location = new System.Drawing.Point(180, 300);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(160, 60);
            this.signInButton.TabIndex = 5;
            this.signInButton.Text = "Войти";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // showPass
            // 
            this.showPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showPass.AutoSize = true;
            this.showPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPass.Image = global::authorization.Properties.Resources.closed_eye;
            this.showPass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showPass.Location = new System.Drawing.Point(427, 165);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(61, 43);
            this.showPass.TabIndex = 4;
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::authorization.Properties.Resources._lock;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(40, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 80);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // passField
            // 
            this.passField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passField.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passField.Location = new System.Drawing.Point(141, 168);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(280, 45);
            this.passField.TabIndex = 2;
            this.passField.UseSystemPasswordChar = true;
            // 
            // userPic
            // 
            this.userPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userPic.BackgroundImage = global::authorization.Properties.Resources.user;
            this.userPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userPic.Location = new System.Drawing.Point(40, 30);
            this.userPic.Name = "userPic";
            this.userPic.Size = new System.Drawing.Size(82, 80);
            this.userPic.TabIndex = 1;
            this.userPic.TabStop = false;
            // 
            // loginField
            // 
            this.loginField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginField.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginField.Location = new System.Drawing.Point(141, 50);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(347, 45);
            this.loginField.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Lavender;
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 30);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(500, 130);
            this.headerPanel.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Georgia", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(500, 130);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Авторизация";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taskbarPanel
            // 
            this.taskbarPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.taskbarPanel.Controls.Add(this.minimizeButton);
            this.taskbarPanel.Controls.Add(this.maximizeButton);
            this.taskbarPanel.Controls.Add(this.closeButton);
            this.taskbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.taskbarPanel.Location = new System.Drawing.Point(0, 0);
            this.taskbarPanel.Name = "taskbarPanel";
            this.taskbarPanel.Size = new System.Drawing.Size(500, 30);
            this.taskbarPanel.TabIndex = 0;
            this.taskbarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.taskbarPanel_MouseDown);
            this.taskbarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.taskbarPanel_MouseMove);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImage = global::authorization.Properties.Resources.minimize;
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeButton.Location = new System.Drawing.Point(410, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(30, 30);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.BackgroundImage = global::authorization.Properties.Resources.expand;
            this.maximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maximizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximizeButton.Location = new System.Drawing.Point(440, 0);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(30, 30);
            this.maximizeButton.TabIndex = 1;
            this.maximizeButton.UseVisualStyleBackColor = true;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::authorization.Properties.Resources.cross;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.Location = new System.Drawing.Point(470, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // goToRegistration
            // 
            this.goToRegistration.AutoSize = true;
            this.goToRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToRegistration.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToRegistration.ForeColor = System.Drawing.Color.SteelBlue;
            this.goToRegistration.Location = new System.Drawing.Point(176, 8);
            this.goToRegistration.Name = "goToRegistration";
            this.goToRegistration.Size = new System.Drawing.Size(176, 23);
            this.goToRegistration.TabIndex = 0;
            this.goToRegistration.Text = "Ещё нет аккаунта?";
            this.goToRegistration.Click += new System.EventHandler(this.goToRegistration_Click);
            this.goToRegistration.MouseEnter += new System.EventHandler(this.goToRegistration_MouseEnter);
            this.goToRegistration.MouseLeave += new System.EventHandler(this.goToRegistration_MouseLeave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.backgroundPanel);
            this.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.backgroundPanel.ResumeLayout(false);
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.taskbarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.Panel taskbarPanel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.PictureBox userPic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Label goToRegistration;
    }
}