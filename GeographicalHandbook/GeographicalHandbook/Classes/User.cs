using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicalHandbook.Classes
{
    public class User
    {
        private List<string> marks;
        private List<TerritoryObject> visitedPlaces;
        private List<TerritoryObject> plannedPlaces;
        public User(string[] logPas, string[] nameSurname, string marksFromFile)
        {
            Login = logPas[0];
            Password = logPas[1];
            Surname = nameSurname[0];
            Name = nameSurname[1];
            visitedPlaces = new List<TerritoryObject>();
            plannedPlaces = new List<TerritoryObject>();
            marks = new List<string>(marksFromFile.Split('*'));
            
        }
        public User(string log, string pas, string nam, string surnam)
        {
            Login = log;
            Password = pas;
            Surname = surnam;
            Name = nam;
            visitedPlaces = new List<TerritoryObject>();
            plannedPlaces = new List<TerritoryObject>();
            marks = new List<string>();
            
        }
        public string[] GetMarks(int i)
        {
            return marks[i].Split('|'); 
        }
        public int NumOfGames 
        { 
            get 
            { 
                return marks.Count; 
            } 
        }
        public void AddMark(int got, int max)
        {
            marks.Add(string.Format("{0}|{1}|{2}", got, max, DateTime.Now.ToShortDateString().ToString()));
        }
        public string GetMarksToFile()
        {
            return String.Join("*", marks);
        }
        public void CreateMarks(string data)
        {
            string[] dataArr = data.Split('*');
            foreach (string s in dataArr)
            {
                marks.Add(s);
            }
            marks.Add(dataArr.Length.ToString());
            
        }
        public string Login
        {
            get;
            private set;
        }
        public string Password
        {
            get;
            set;
        }
        public string Name
        {
            get;
            private set;
        }
        public string Surname
        {
            get;
            private set;
        }
    }
}
