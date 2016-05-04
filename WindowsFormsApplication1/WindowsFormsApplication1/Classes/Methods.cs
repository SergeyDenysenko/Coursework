using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GeographicalHandbook.Classes
{
    class Methods
    {
        public static void BuildHandbook(List<Country> countries) {
            BuildCountries(countries);
            BuildRegions(countries);
            BuildCities(countries);
        }
        
        public static void BuildMainlands(List<Mainland> mainlands)
        {
            StreamReader land = new StreamReader(@"mainlands.txt");
            int numOfLands = 6;
            int i;
            for (i = 0; i < numOfLands; i++)
            {
                mainlands.Add(BuildMainland(land));
            }
        }
        private static Mainland BuildMainland(StreamReader ld)
        {
            return new Mainland(ld.ReadLine(), Convert.ToInt32(ld.ReadLine()), Convert.ToDouble(ld.ReadLine()));
        }

        private static void BuildCities(List<Country> countries)
        {
            TextReader city = new StreamReader(@"cities.txt");
            int numberOfCities = Convert.ToInt32(city.ReadLine());
            int i, j, k;
            string infCountry;
            string infRegion;
            for (i = 0; i < numberOfCities; i++)
            {
                j = 0;
                k = 0;
                infCountry = city.ReadLine();
                infRegion = city.ReadLine();
                while (j < countries.Count)
                {
                    if (countries[j].Name == infCountry)
                    {
                        while (k < countries[j].regions.Count)
                        {
                            if (countries[j].regions[k].GetRegion() == infRegion)
                            {
                                countries[j].regions[k].AddCity(BuildCity(city));
                                break;
                            }
                            else k++;
                        }
                        break;
                    }
                    else j++;
                }

            }





        }

        private static void BuildCountries(List<Country> countries)
        {

            TextReader country = new StreamReader(@"countries.txt");
            int numberOfCountries = Convert.ToInt32(country.ReadLine());
            string mainland;
            for (int i = 0; i < numberOfCountries; i++)
            {
                mainland = country.ReadLine();

                countries.Add(BuildCountry(country));

            }

        }

        private static void BuildRegions(List<Country> countries)
        {
            TextReader region = new StreamReader(@"regions.txt");
            int numberOfRegions = Convert.ToInt32(region.ReadLine());
            for (int i = 0; i < numberOfRegions; i++)
            {
                string countryName = region.ReadLine();
                int j = 0;
                while (countryName != countries[j].Name) j++;
                countries[j].AddRegion(BuildRegion(region));
            }
        }
        
        private static Country BuildCountry(TextReader cry)
        {
            return new Country(cry.ReadLine(), cry.ReadLine(), Convert.ToInt32(cry.ReadLine()), Convert.ToInt32(cry.ReadLine()));
        }
        private static Region BuildRegion(TextReader rn)
        {
            return new Region(rn.ReadLine(), rn.ReadLine(), Convert.ToInt32(rn.ReadLine()), Convert.ToInt32(rn.ReadLine()));
        }
        private static City BuildCity(TextReader cy)
        {
            return new City(cy.ReadLine(), Convert.ToInt32(cy.ReadLine()), Convert.ToDouble(cy.ReadLine()));
        }
        public static Region SearchInRegions(List<Region> current, string search)
        {
            for (int i = 0; i < current.Count; i++)
            {
                if (search == current[i].Name) return current[i];
            }
            return null;
        }
        public static City SearchInCities(List<Region> current, string search)
        {
            foreach (Region region in current)
            {
                foreach (City city in region.cities)
                {
                    if (city.Name == search) return city;
                }
            }
            return null;
        }

        public static double PercentOfCitiesPopulation(Region current)
        {
            int countCitiesPopulation = 0;
            foreach (City p in current.cities) {
                countCitiesPopulation += p.Population;
            }
            return (double)countCitiesPopulation / current.Population;
        }
    }
}
