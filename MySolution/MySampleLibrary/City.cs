using System;
using System.Collections.Generic;
using System.Text;

namespace MySampleLibrary
{
    public class City
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Size { get; set; }



        public static List<City> GetSampleCities()
        {
            City c1 = new City
            {
                Name = "Seoul",
                Location = "Korea",
                Size = "Big"
            };

            City c2 = new City
            {
                Name = "York",
                Location = "USA",
                Size = "Big"
            };

            City c3 = new City
            {
                Name = "양구",
                Location = "한국",
                Size = "Small"
            };

            List<City> cities = new List<City> { c1, c2, c3 };
            return cities;


        }

    }




    



}
