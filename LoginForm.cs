using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace authorization
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
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
        /////////////////////////////////////////////
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                showPass.Image = Properties.Resources.opened_eye;
                passField.UseSystemPasswordChar = false;
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

        private void signInButton_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passUser = passField.Text;
            connectionDatabase myDatabase = new connectionDatabase();
            DataTable myTable = new DataTable();
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();
            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM `authorization` " +
                "WHERE `login` = @uL AND `pass` = @uP", myDatabase.getConnection());
            myCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            myCommand.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            myAdapter.SelectCommand = myCommand;

            myAdapter.Fill(myTable);
            if (myTable.Rows.Count > 0)

            {
                MessageBox.Show("Welcome!");
            }
            else
            {
                MessageBox.Show("Sorry");
            }
        }

        private void goToRegistration_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Hide();
            this.Hide();
            loginForm.Close();
            Registration registrationForm = new Registration();
            registrationForm.Show();
        }

        private void goToRegistration_MouseEnter(object sender, EventArgs e)
        {
            goToRegistration.ForeColor = Color.Blue;
        }

        private void goToRegistration_MouseLeave(object sender, EventArgs e)
        {
            goToRegistration.ForeColor = Color.SteelBlue;
        }
    }
}
