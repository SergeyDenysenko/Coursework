using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeographicalHandbook.Classes;

namespace GeographicalHandbook
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();

        }
        public Earth earth;
        private void button1_Click(object sender, EventArgs e)
        {
            User current = Methods.Authorization2(login.Text, password.Text);
            if (current != null)
            {
                MainForm f = (MainForm)this.Owner;
                f.signInToolStripMenuItem.Visible = false;
                f.cabinetToolStripMenuItem.Visible = true;
                f.currentUser = current;
                this.Close();
            }
            else
            {
                errorAuth.Text = "Invalid login or password";
                login.Text = "";
                password.Text = "";
            }
        }
        private void Authorization_Load(object sender, EventArgs e)
        {
            MainForm form = (MainForm)this.Owner;
            earth = form.GetData;
        }
        private void regButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            foreach (Control cur in regPage.Controls)
            {
                if (cur is TextBox && cur.Text.Length == 0)
                {
                    errorLabel.Text = "Fill in all the fields \n";
                    break;
                }
            }
            if (Methods.SearchLogin(logReg.Text))
            {
                logReg.ForeColor = Color.Red;
                errorLabel.Text += string.Format("Login {0} is alredy taken! \n", logReg.Text);
            }
            if (passReg.Text != passReg2.Text)
            {
                errorLabel.Text += "Passwords are not Equal \n";
                passReg2.ForeColor = passReg.ForeColor = Color.Red; 
            }
            if (passReg2.Text.Length < 6) 
            {
                errorLabel.Text += "Password is too short \n";
                passReg2.ForeColor = passReg.ForeColor = Color.Red; 
            }
            if (errorLabel.Text.Length == 0)
            {
                Methods.AddUser(new User(logReg.Text, passReg.Text, nameReg.Text, surnameReg.Text));
                errorLabel.Text = "Profile is created!";
                foreach (Control cur in regPage.Controls)
                {
                    if (cur is TextBox)
                        cur.Text = "";
                }
            }
        }
    }
}
