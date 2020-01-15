using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace authorization
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            nameField.Text = "Введите имя";
            nameField.ForeColor = Color.SteelBlue;
            surnameField.Text = "Введите фамилия";
            surnameField.ForeColor = Color.SteelBlue;
            loginField.Text = "Введите логин";
            loginField.ForeColor = Color.SteelBlue;
            passField.Text = "Введите пароль";
            passField.ForeColor = Color.SteelBlue;
            passField.UseSystemPasswordChar = false;
            showPass.Image = Properties.Resources.opened_eye;
            showPass.Checked = true;
        }
        private const int cGrip = 22;      // Grip size
        private const int cCaption = 44;   // Caption bar height;

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                maximizeButton.BackgroundImage = Properties.Resources.restore;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                maximizeButton.BackgroundImage = Properties.Resources.expand;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                showPass.Image = Properties.Resources.opened_eye;
                passField.UseSystemPasswordChar = false;
                passField.ForeColor = Color.SteelBlue;
                if (passField.Text != "Введите пароль")
                {
                    passField.ForeColor = Color.Black;
                }
            }
            else
            {
                showPass.Image = Properties.Resources.closed_eye;
                passField.UseSystemPasswordChar = true;
            }
        }
        Point lastPoint;
        private void taskbarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void taskbarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void nameField_Enter(object sender, EventArgs e)
        {
            if (nameField.Text == "Введите имя")
            {
                nameField.Text = "";
            }
            nameField.ForeColor = Color.Black;
        }

        private void nameField_Leave(object sender, EventArgs e)
        {
            if (nameField.Text == "")
            {
                nameField.ForeColor = Color.SteelBlue;
                nameField.Text = "Введите имя";
            }
        }

        private void surnameField_Enter(object sender, EventArgs e)
        {
            if (surnameField.Text == "Введите фамилия")
            {
                surnameField.Text = "";
            }
            surnameField.ForeColor = Color.Black;
        }

        private void surnameField_Leave(object sender, EventArgs e)
        {
            if (surnameField.Text == "")
            {
                surnameField.ForeColor = Color.SteelBlue;
                surnameField.Text = "Введите фамилия";
            }
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
            {
                loginField.Text = "";
            }
            loginField.ForeColor = Color.Black;
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.ForeColor = Color.SteelBlue;
                loginField.Text = "Введите логин";
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Введите пароль")
            {
                passField.Text = "";
            }
            passField.ForeColor = Color.Black;
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            passField.UseSystemPasswordChar = false;
            if (passField.Text == "")
            {
                nameField.ForeColor = Color.SteelBlue;
                passField.Text = "Введите пароль";
            }
            passField.ForeColor = Color.Black;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {

            if (nameField.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя!");
                return;
            }
            if (surnameField.Text == "Введите фамилия")
            {
                MessageBox.Show("Введите фамилия!");
                return;
            }
            if (loginField.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин!");
                return;
            }
            if (loginField.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль!");
                return;
            }

            if (isUserExists())
            {
                return;
            }
            connectionDatabase myDatabase = new connectionDatabase();
            MySqlCommand myCommand = new MySqlCommand("INSERT INTO `authorization` " +
                "(`name`, `surname`, `login`, `pass`) VALUES " +
                "(@userName, @userSurname, @userLogin, @userPass)", myDatabase.getConnection());

            myCommand.Parameters.Add("@userName", MySqlDbType.VarChar).Value = nameField.Text;
            myCommand.Parameters.Add("@userSurname", MySqlDbType.VarChar).Value = surnameField.Text;
            myCommand.Parameters.Add("@userLogin", MySqlDbType.VarChar).Value = loginField.Text;
            myCommand.Parameters.Add("@userPass", MySqlDbType.VarChar).Value = passField.Text;

            myDatabase.openConnection();
            if (myCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт был создан");
                Registration registrationForm = new Registration();
                registrationForm.Hide();
                registrationForm.Close();
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Что-то не так");
            }
            myDatabase.closeConnection();
        }
        public Boolean isUserExists()
        {
            connectionDatabase myDatabase = new connectionDatabase();
            DataTable myTable = new DataTable();
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();
            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM `authorization` " +
                "WHERE `login` = @uL", myDatabase.getConnection());
            myCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;

            myAdapter.SelectCommand = myCommand;

            myAdapter.Fill(myTable);
            if (myTable.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует, выберите другой!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void goToRegistration_MouseEnter(object sender, EventArgs e)
        {
            goToLoginForm.ForeColor = Color.Blue;
        }

        private void goToRegistration_MouseLeave(object sender, EventArgs e)
        {
            goToLoginForm.ForeColor = Color.SteelBlue;
        }

        private void goToLoginForm_Click(object sender, EventArgs e)
        {
            Registration registrationForm = new Registration();
            registrationForm.Hide();
            registrationForm.Close();
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
