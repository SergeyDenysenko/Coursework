using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GeographicalHandbook.Classes;


namespace GeographicalHandbook
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Methods.BuildMainlands(mainlands);
            Methods.BuildHandbook(countries);

            label1.Text = Methods.PercentOfCitiesPopulation(countries[0].regions[0]).ToString();
                        
        }
        List<Country> countries = new List<Country>();
        List<Mainland> mainlands = new List<Mainland>();

        
       
        
        private void button1_Click(object sender, EventArgs e)
        {
            string toSearch = textBox1.Text;
            Region searchedRegion;
            City searchedCity;
            for (int i = 0; i < countries.Count; i++)
            {
                
                if (countries[i].Name == toSearch || countries[i].Capital == toSearch)
                {
                    countriesTable.Rows.Add(countries[i].Name, countries[i].Capital, countries[i].Population, countries[i].Area);
                }
                searchedRegion = Methods.SearchInRegions(countries[i].regions, toSearch);
                if (searchedRegion != null) countriesTable.Rows.Add(searchedRegion.Name, searchedRegion.MainCity, searchedRegion.Population);
                searchedCity = Methods.SearchInCities(countries[i].regions, toSearch);
                if (searchedCity != null) countriesTable.Rows.Add(searchedCity.Name, searchedCity.Population, searchedCity.Area);
                
            }
        }

        private void countriesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
