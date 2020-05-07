using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries_Lab
{
    class CountryController 
    {
           
        public List<Country> CountryDB = new List<Country>();

        public CountryController()
        {
            Country usa = new Country();
            List<string> usacolor = new List<string>() { "Red", "White", "Blue" };
            usa.Name = "United States of America";
            usa.Continent = "North America";
            usa.Colors = usacolor;
            CountryDB.Add(usa);

            Country china = new Country();
            List<string> chinacolor = new List<string>() { "Red", "White" };
            china.Name = "China";
            china.Continent = "Asia";
            china.Colors = chinacolor;
            CountryDB.Add(china);

            Country armenia = new Country();
            List<string> armeniacolor = new List<string>() { "Red", "Blue", "Yellow" };
            armenia.Name = "Armenia";
            armenia.Continent = "Asia";
            armenia.Colors = armeniacolor;
            CountryDB.Add(armenia);
            
        }
        public CountryController(Country CountryView)
        {

        }
        public void CountryAction(Country c)
        {
            CountryView country = new CountryView(c);
            country.Display();
        }

        public void WelcomeAction()
        {
            CountryListView a = new CountryListView(CountryDB);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list: ");
            a.Display();

            for (int i = 0; i < CountryDB.Count; i++)
            {
                Country b = CountryDB[i];
                Console.WriteLine($"{i}: {b.Name}");
            }
            string answer = Console.ReadLine();
            int index = int.Parse(answer);

            Country output = CountryDB[index];
            CountryAction(CountryDB[index]);
            
          
            
        }

        public void SecondAction()
        {
            CountryListView countries = new CountryListView(CountryDB);
            countries.Display();
            string answer = Console.ReadLine();
            int index = int.Parse(answer);
            Console.WriteLine();
            CountryAction(CountryDB[index]);
        }
    }
}
