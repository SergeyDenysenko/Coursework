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
    public partial class Cabinet : Form
    {
        public Cabinet(User currentUser)
        {
            InitializeComponent();
            user = currentUser;
            FillCabinet();
        }
        User user;
        private void FillCabinet()
        {
            personalData.Text = string.Format("Hello, {0} {1}!", user.Name, user.Surname);
            int i;
            string[] gameInfo;
            for (i = 1; i < user.NumOfGames; i++)
            {
                try
                {
                    gameInfo = user.GetMarks(i);
                    double percentage = Math.Round((Convert.ToDouble(gameInfo[0]) / Convert.ToDouble(gameInfo[1])), 3);
                    marksDataGrid.Rows.Add(gameInfo[2], gameInfo[0] + "/" + gameInfo[1], percentage);
                }
                catch (IndexOutOfRangeException)
                {
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            marksDataGrid.Visible = false;
            panel1.Visible = true;
            loginLbl.Text = user.Login;
            passLbl.Text = "******";
            nameLbl.Text = user.Name;
            surnameLbl.Text = user.Surname;
        }
        private void changeData_Click(object sender, EventArgs e)
        {
            changedPass.Visible = true;
            changeData.Visible = false;
            changer.Visible = true;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            marksDataGrid.Visible = true;
            panel1.Visible = false;
            changedPass.Visible = false;
            changeData.Visible = true;
            changer.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            passLbl.Text = user.Password;
        }
        private void changer_Click(object sender, EventArgs e)
        {
            user.Password = changedPass.Text;
            changedPass.Visible = false;
            changeData.Visible = true;
            changer.Visible = false;
            Methods.UpdateUserData(user);
        }
    }
}
