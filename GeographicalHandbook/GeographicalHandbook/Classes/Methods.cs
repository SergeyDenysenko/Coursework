using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GeographicalHandbook.Classes
{
    public abstract class Methods
    {
        public static void BuildHandbook(Earth earth)
        {
            BuildEarth(earth);
            AddCountries(earth);
            AddRegions(earth);
            AddCities(earth);
        }
        public static void AddUser(User user)
        {
            TextWriter addUser = new StreamWriter(@"data/users.txt", true);
            addUser.WriteLine(user.Login + "&");
            addUser.WriteLine(user.Password + "&");
            addUser.WriteLine(user.Name + "&");
            addUser.WriteLine(user.Surname + "&");
            addUser.WriteLine("&");
            addUser.Close();
        }
        public static User Authorization(string login, string password)
        {
            TextReader userData = new StreamReader(@"data/users.txt");
            string data = userData.ReadToEnd();
            userData.Close();
            string[] dataArr = data.Split('&');
            int i;
            for (i = 0; i < dataArr.Length; i++)
            {
                dataArr[i] = dataArr[i].Replace(Environment.NewLine, "");
            }

            for (i = 0; i < dataArr.Length; i += 5)
            {
                if (dataArr[i] == login && dataArr[i + 1] == password)
                {
                    User current = new User(dataArr[i], dataArr[i + 1], dataArr[i + 2], dataArr[i + 3]);
                    current.CreateMarks(dataArr[i + 4]);
                    return current;
                }
            }
            return null;
        }
        public static void UpdateUserData(User user)
        {
            TextReader userData = new StreamReader(@"data/users.txt");
            int i;
            string data;
            string[] dataArr;
            data = userData.ReadToEnd();
            userData.Close();
            dataArr = data.Split('&');
            for (i = 0; i < dataArr.Length; i++)
            {
                if (dataArr[i].Replace(Environment.NewLine, "") == user.Login)
                {
                    dataArr[i + 1] = Environment.NewLine + user.Password;
                    dataArr[i + 4] = Environment.NewLine + user.GetMarksToFile();
                    break;
                }
            }
            TextWriter updater = new StreamWriter(@"data/users.txt");
            updater.Write(String.Join("&", dataArr));

            updater.Close();
        }
        public static bool SearchLogin(string toCheck)
        {
            TextReader users = new StreamReader(@"data/users.txt");
            string line;
            while ((line = users.ReadLine()) != null)
            {
                if ((line = line.Replace("&", "")) == toCheck)
                    return true;
            }
            users.Close();
            return false;
        }
        public static List<TerritoryObject> GetCountries(int quantity, Earth earth)
        {
            List<TerritoryObject> result = new List<TerritoryObject>();
            bool[,] selected = new bool[5, 20];
            int i;
            int index1, index2;
            Random random = new Random();
            for (i = 0; i < quantity; i++)
            {
                do
                {
                    index1 = random.Next(0, earth.Length - 1);
                    index2 = random.Next(0, earth[index1].Length);
                }
                while (selected[index1, index2]);
                selected[index1, index2] = true;
                result.Add(earth[index1][index2]);
            }
            return result;
        }
        public static void ContinentsBorder(List<TerritoryObjectBorder> continents, Form myForm)
        {
            Graphics g = myForm.CreateGraphics();
            GraphicsPath europe = new GraphicsPath();
            europe.AddLine(487, 247, 389, 247);
            europe.AddBezier(389, 247, 357, 259, 348, 231, 375, 229);
            europe.AddBezier(375, 229, 345, 179, 369, 166, 388, 197);
            europe.AddBezier(388, 197, 381, 129, 435, 110, 475, 146);
            europe.AddLine(492, 243, 487, 247);
            europe.CloseFigure();

            GraphicsPath northAmerica = new GraphicsPath();
            northAmerica.AddLine(191, 346, 66, 182);
            northAmerica.AddBezier(66, 182, 0, 175, 0, 111, 53, 124);
            northAmerica.AddLine(53, 124, 249, 54);
            northAmerica.AddLine(249, 54, 276, 228);
            northAmerica.AddLine(276, 228, 191, 346);
            northAmerica.CloseFigure();

            GraphicsPath southAmerica = new GraphicsPath();
            southAmerica.AddBezier(194, 346, 193, 344, 241, 320, 273, 349);
            southAmerica.AddLine(271, 349, 317, 379);
            southAmerica.AddLine(317, 379, 226, 570);
            southAmerica.AddLine(226, 570, 194, 394);
            northAmerica.CloseFigure();

            GraphicsPath africa = new GraphicsPath();
            africa.AddBezier(388, 364, 398, 476, 479, 468, 512, 344);
            africa.AddLine(512, 344, 449, 267);
            africa.AddLine(449, 267, 405, 254);
            africa.AddBezier(405, 254, 314, 258, 324, 372, 388, 364);
            africa.CloseFigure();

            GraphicsPath australia = new GraphicsPath();
            australia.AddRectangle(new Rectangle(620, 400, 175, 530));

            GraphicsPath asia = new GraphicsPath();
            asia.AddLine(473, 95, 793, 50);
            asia.AddLine(793, 50, 714, 395);
            asia.AddLine(714, 395, 488, 328);
            asia.AddLine(488, 328, 455, 271);
            asia.AddLine(455, 271, 473, 95);
            asia.CloseFigure();

            continents.Add(new TerritoryObjectBorder("europe", europe));
            continents.Add(new TerritoryObjectBorder("northamerica", northAmerica));
            continents.Add(new TerritoryObjectBorder("southamerica", southAmerica));
            continents.Add(new TerritoryObjectBorder("africa", africa));
            continents.Add(new TerritoryObjectBorder("australia", australia));
            continents.Add(new TerritoryObjectBorder("asia", asia));
        }
        private static void BuildEarth(Earth earth)
        {
            TextReader cont = new StreamReader(@"data/mainlands.txt");
            int i;
            for (i = 0; i < 6; i++)
            {
                earth.AddChild(AddContinent(cont));
            }
            cont.Close();
        }
        private static void AddCountries(Earth earth)
        {
            TextReader countryList = new StreamReader(@"data/countries.txt");
            int numOfCountries = Convert.ToInt32(countryList.ReadLine());
            int i;
            int continentIndex;
            for (i = 0; i < numOfCountries; i++)
            {
                continentIndex = GetContinentIndex(earth, countryList);
                earth[continentIndex].AddChild(AddCountry(countryList));
            }
            countryList.Close();
        }
        private static void AddRegions(Earth earth)
        {
            TextReader regionList = new StreamReader(@"data/regions.txt");
            int i;
            int continentIndex;
            int numOfRegions = Convert.ToInt32(regionList.ReadLine());
            string countryName;
            TerritoryObject searchedCountry;
            for (i = 0; i < numOfRegions; i++)
            {

                continentIndex = GetContinentIndex(earth, regionList);
                countryName = regionList.ReadLine();
                searchedCountry = earth[continentIndex].GetChildByName(countryName);
                if (searchedCountry != null) searchedCountry.AddChild(AddRegion(regionList));
            }
        }
        private static void AddCities(Earth earth)
        {
            TextReader cityList = new StreamReader(@"data/cities.txt");
            int i;
            int continentIndex;
            int numOfCities = Convert.ToInt32(cityList.ReadLine());
            string countryName;
            string regionName;
            TerritoryObject searchedCountry;
            TerritoryObject searchedRegion;
            for (i = 0; i < numOfCities; i++)
            {
                continentIndex = GetContinentIndex(earth, cityList);
                countryName = cityList.ReadLine();
                regionName = cityList.ReadLine();
                searchedCountry = earth[continentIndex].GetChildByName(countryName);
                searchedRegion = searchedCountry.GetChildByName(regionName);
                searchedRegion.AddChild(AddCity(cityList));
            }
        }
        private static int GetContinentIndex(Earth earth, TextReader reader)
        {
            string searchedValue = reader.ReadLine();
            int j = 0;
            while (j < earth.Length && earth[j].Name != searchedValue)
                j++;
            return j;
        }
        private static Country AddCountry(TextReader cry)
        {
            return new Country(cry.ReadLine(), cry.ReadLine(), Convert.ToInt64(cry.ReadLine()), Convert.ToDouble(cry.ReadLine()));
        }
        private static CRegion AddRegion(TextReader rn)
        {
            return new CRegion(rn.ReadLine(), rn.ReadLine(), Convert.ToInt64(rn.ReadLine()), Convert.ToDouble(rn.ReadLine()));
        }
        private static City AddCity(TextReader cty)
        {
            return new City(cty.ReadLine(), Convert.ToInt64(cty.ReadLine()), Convert.ToDouble(cty.ReadLine()));
        }
        private static Continent AddContinent(TextReader land)
        {
            return new Continent(land.ReadLine(), Convert.ToInt64(land.ReadLine()), Convert.ToDouble(land.ReadLine()));
        }
    }
}
