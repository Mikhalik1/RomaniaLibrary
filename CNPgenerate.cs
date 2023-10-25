using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomaniaLibrary
{
    public class CNPgenerate
    {
         Random rnd = new Random();
        public static string CNPgen(DateTime databirth,int CityCode, int isfemale,string lastName,string cnp,bool resident)
        {
            Random rnd = new Random();
            //DateTime dateStart = new DateTime(1900, 1, 1);
            int year = databirth.Year;
            int month = databirth.Month;
            int day = databirth.Day;
            string firstdigit = "";
            int lastyear = year % 100;
          if (resident == true) { 
            if(databirth.Year >= 1900 && databirth.Year <= 1949)
            {
                firstdigit= "1";
            }
            if (databirth.Year >= 1950 && databirth.Year <= 1999)
            {
                firstdigit = "1";
            }
            if (databirth.Year >= 1800 && databirth.Year <= 1849)
            {
                firstdigit = "1";
            }
            if (databirth.Year >= 1850 && databirth.Year <= 1899)
            {
                firstdigit = "1";
            }
            if (databirth.Year >= 2000 && databirth.Year <= 2049)
            {
                firstdigit = "1";
            }
            if (databirth.Year >= 2050 && databirth.Year <= 2099)
            {
                firstdigit = "1";
            }
           }
        else
        {
          firstdigit = rnd.Next(7,10).ToString();
        }
            firstdigit += lastyear.ToString();
            firstdigit += databirth.ToString("MM");
            firstdigit += databirth.ToString("dd");
            firstdigit += CityCode.ToString();
            
            firstdigit += isfemale.ToString();
            return lastName;
        }
    }
}
