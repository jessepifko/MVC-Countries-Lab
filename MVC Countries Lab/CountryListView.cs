using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries_Lab
{
    class CountryListView
    {
        public List<Country> countries { get; set; }
        public List<Country> CountryDB = new List<Country>();

        public CountryListView(List<Country> countries)
        {
            this.countries = countries;
        }

        public void Display()
        {

            for (int i = 0; i < CountryDB.Count; i++)
            {
                Country b = CountryDB[i];
                Console.WriteLine($"{i}: {b.Name}");
            }
            Console.WriteLine("Please select a country from the list by Index: ");



        }

    }
}
