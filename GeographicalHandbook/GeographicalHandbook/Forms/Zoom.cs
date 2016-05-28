using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using GeographicalHandbook.Classes;



namespace GeographicalHandbook
{
    public partial class Zoom : Form
    {
        public Zoom()
        {
            InitializeComponent();
            countries = new List<TerritoryObjectBorder>();
        }
        List<TerritoryObjectBorder> countries;
        private void AddEurope(List<TerritoryObjectBorder> result)
        {
            GraphicsPath ukraine = new GraphicsPath();
            ukraine.AddBezier(402, 350, 365, 341, 370, 312, 398, 310);
            ukraine.AddBezier(398, 310, 390, 300, 396, 289, 410, 292);
            ukraine.AddLine(410, 292, 459, 313);
            ukraine.AddBezier(459, 313, 463, 299, 509, 307, 504, 327);
            ukraine.AddLine(504, 327, 540, 354);
            ukraine.AddBezier(540, 354, 560, 365, 553, 392, 527, 392);
            ukraine.AddLine(527, 392, 498, 397);
            ukraine.AddBezier(498, 397, 505, 430, 461, 412, 474, 393);
            ukraine.AddLine(474, 393, 427, 393);
            ukraine.AddLine(427, 393, 444, 373);
            ukraine.AddBezier(444, 373, 443, 343, 406, 341, 402, 350);
            result.Add(new TerritoryObjectBorder("Ukraine", ukraine));

        }
        private void AddNorthAmerica(List<TerritoryObjectBorder> result)
        {
            GraphicsPath usa = new GraphicsPath();
            usa.AddLine(232, 221, 374, 219);
            usa.AddLine(374, 219, 432, 245);
            usa.AddLine(432, 245, 438, 268);
            usa.AddBezier(438, 268, 512, 212, 539, 227, 471, 286);
            usa.AddLine(471, 286, 474, 366);
            usa.AddLine(474, 366, 442, 335);
            usa.AddBezier(442, 35, 452, 375, 435, 379, 428, 339);
            usa.AddLine(428, 339, 363, 357);
            usa.AddLine(363, 357, 334, 338);
            usa.AddLine(334, 338, 260, 318);
            usa.AddBezier(260, 318, 221, 296, 208, 262, 232, 221);
            usa.AddLine(136, 92, 137, 154);
            usa.AddBezier(137, 154, -19, 168, -19, 73, 136, 92);
            result.Add(new TerritoryObjectBorder("USA", usa));
            GraphicsPath canada = new GraphicsPath();
            canada.AddLine(229, 220, 403, 222);
            canada.AddLine(403, 222, 473, 241);
            canada.AddLine(473, 241, 578, 217);
            canada.AddBezier(578, 217, 505, 36, 363, 17, 140, 93);
            canada.AddLine(140, 93, 143, 151);
            canada.AddLine(143, 151, 229, 220);
            result.Add(new TerritoryObjectBorder("Canada", canada));
        }
        private void AddAustralia(List<TerritoryObjectBorder> result)
        {
            GraphicsPath aust = new GraphicsPath();
            aust.AddLine(54, 323, 31, 224);
            aust.AddLine(31, 224, 226, 122);
            aust.AddBezier(226, 122, 214, 165, 277, 200, 280, 128);
            aust.AddLine(280, 128, 388, 254);
            aust.AddLine(388, 254, 330, 415);
            aust.AddBezier(330, 415, 257, 276, 129, 288, 54, 323);
            result.Add(new TerritoryObjectBorder("Australia", aust));
        }
        private void AddBorders(int x, int y)
        {
            foreach (TerritoryObjectBorder cur in countries) {
                if (cur.border.IsVisible(x, y))
                {
                    MainForm f = (MainForm)this.Owner;
                    if (f != null) 
                        f.OpenInfo(cur.Name);
                    break;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddBorders(0, 0);
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            AddBorders(e.Location.X, e.Location.Y);
        }

        private void Zoom_Load(object sender, EventArgs e)
        {
            switch (this.pictureBox1.ImageLocation)
            {
                case "images/northamerica.jpg": 
                    AddNorthAmerica(countries);
                    break;
                case "images/europe.jpg":
                    AddEurope(countries);
                    break;
                case "images/australia.jpg":
                    AddAustralia(countries);
                    break;
            }
        }
    }
}
