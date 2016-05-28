using System;
using GeographicalHandbook.Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading;

namespace GeographicalHandbook
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Methods.BuildHandbook(earth);
            Methods.ContinentsBorder(continents, this);
        }
        
        Earth earth = new Earth();
        List<TerritoryObjectBorder> continents = new List<TerritoryObjectBorder>();
        public User currentUser;
        
        public Earth GetData 
        { 
            get 
            { 
                return earth;
            } 
        }
        public void OpenInfo(string s)
        {
            TerritoryObject clickedObject = earth.SearchFullName(s);
            OpenInfo(clickedObject);
        }
        private void OpenInfo(TerritoryObject clickedObject)
        {
            int i;
            Info infoObject = new Info(earth);
            infoObject.Owner = this;
            infoObject.Text = clickedObject.Name;
            infoObject.countryImg.ImageLocation = "images/" + clickedObject.Name + ".png";
            infoObject.flagImg.ImageLocation = "images/" + clickedObject.Name + "Flag.png";
            infoObject.objName.Text = clickedObject.Name;
            infoObject.objPop.Text = clickedObject.Population.ToString();
            infoObject.objCapital.Text = clickedObject.Capital;
            infoObject.objArea.Text = clickedObject.Area.ToString();
            infoObject.Show();
            for (i = 0; i < clickedObject.Length; i++)
            {
                infoObject.dataGridReg.Rows.Add(clickedObject[i].Name, clickedObject[i].Capital, clickedObject[i].Population, clickedObject[i].Area);
            }
                
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchQuery.Text != "")
            {
                List<TerritoryObject> searchResult = new List<TerritoryObject>();
                earth.Search(searchQuery.Text, searchResult);
                if (searchResult.Count != 0)
                {
                    this.dataGrid.Rows.Add(searchResult[0].Name, searchResult[0].Capital, searchResult[0].Population, searchResult[0].Area);
                    dataGrid.Visible = true;
                }
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string ev = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                TerritoryObject clickedObject = earth.SearchFullName(ev);
                OpenInfo(clickedObject);
            }
        }
        private void countBtn_Click(object sender, EventArgs e)
        {
            if (countUrban.Text != "")
            {
                TerritoryObject searched = earth.SearchFullName(countUrban.Text);
                if (searched != null)
                {
                    double result = searched.UrbanPopulation();
                    countResult.Text = string.Format("There are {0}% of urban people \n in {1} {2}", Math.Round(result, 2), countUrban.Text, searched.TypeOF == 3 ? "region" : "");
                }
                else
                {
                    countResult.Text = "Object was not found";
                }
            }
        }
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (searchPanel.Visible == false)
                searchPanel.Visible = true;
            else
                searchPanel.Visible = false;
        }
        private void countUrbanPopulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (urbanPanel.Visible == true)
                urbanPanel.Visible = false;
            searchPanel.Visible = true;
        }
        private void searchClose_Click(object sender, EventArgs e)
        {
            searchPanel.Visible = false;
            dataGrid.Rows.Clear();
            searchQuery.Text = "";
            dataGrid.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            urbanPanel.Visible = false;
        }
        private void countUrbanPopulationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            urbanPanel.Visible = true;
        }
        private void showContinentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            closeTableButton.Visible = true;
            int i;
            for (i = 0; i < earth.Length; i++)
            {
                dataGridView1.Rows.Add(earth[i].Name, earth[i].Population, earth[i].Area, earth[i].Length);
            }
        }
        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (TerritoryObjectBorder cur in continents)
            {
                if (cur.border.IsVisible(new Point(e.X, e.Y)))
                {
                    Zoom zoomedMap = new Zoom();
                    zoomedMap.Text = cur.Name.Substring(0, 1).ToUpper() + cur.Name.Substring(1); 
                    zoomedMap.Owner = this;
                    zoomedMap.pictureBox1.ImageLocation = "images/" + cur.Name + ".jpg";
                    zoomedMap.ShowDialog();
                    break;
                }
            }
        }
        private void exercisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercise test = new Exercise(currentUser);
            test.Owner = this;
            test.Show();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            TerritoryObject current = earth.SearchFullName(dataGridView1.Rows[e.RowIndex].Cells["name1"].Value.ToString());
            if (current.TypeOF == 1) 
            {
                dataGridView1.Rows.Clear();
                backTableButton.Visible = true;
                for (i = 0; i < current.Length; i++)
                {
                    dataGridView1.Columns[1].HeaderText = "Capital";
                    dataGridView1.Columns[2].HeaderText = "Population";
                    dataGridView1.Columns[3].HeaderText = "Area";
                    dataGridView1.Rows.Add(current[i].Name, current[i].Capital, current[i].Population, current[i].Area);
                }
            }
            else if (current.TypeOF == 2)
            {
                OpenInfo(current);
            }

        }
        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Owner = this;
            authorization.Show();
        }
        private void cabinetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cabinet cabinet = new Cabinet(currentUser);
            cabinet.Owner = this;
            cabinet.Show();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView1.Rows.Clear();
            closeTableButton.Visible = false;
            backTableButton.Visible = false;
        }
        private void backTableButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int i;
            for (i = 0; i < earth.Length; i++)
            {
                dataGridView1.Rows.Add(earth[i].Name, earth[i].Population, earth[i].Area, earth[i].Length);
            }
        }
    }
}
