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
    public partial class Info : Form
    {
        public Info(Earth earth2)
        {
            InitializeComponent();
            this.earth = earth2;
        }
        Earth earth;
        private void dataGridReg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            TerritoryObject current = earth.SearchFullName(dataGridReg.Rows[e.RowIndex].Cells["nameObj"].Value.ToString());
            if (current != null && current.TypeOF == 3)
            {
                dataGridReg.Rows.Clear();
                for (i = 0; i < current.Length; i++)
                {
                    dataGridReg.Columns[1].Visible = false;
                    dataGridReg.Rows.Add(current[i].Name, current[i].Population, current[i].Area);
                }
            }
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            int i;
            TerritoryObject current = earth.SearchFullName(objName.Text);
            dataGridReg.Rows.Clear();
            for (i = 0; i < current.Length; i++)
            {
                dataGridReg.Columns[1].Visible = true;
                dataGridReg.Rows.Add(current[i].Name, current[i].Capital, current[i].Population, current[i].Area);
            }
        }

        
    }
}
