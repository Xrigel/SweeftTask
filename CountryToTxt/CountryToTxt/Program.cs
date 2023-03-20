using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net.Http;

namespace CountryToTxt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenerateCountryDataFiles();
            Console.ReadLine();
        }
        public static async void GenerateCountryDataFiles()
        {
            string url = "https://restcountries.com/v2/all";

            HttpClient client = new HttpClient();

            string response = await client.GetStringAsync(url);
            
            JArray countries = JArray.Parse(response);

            foreach (var country in countries)
            {
                string fileName = country["name"].ToString() + ".txt";

                using (StreamWriter sw = new StreamWriter($"C:/Users/George/Desktop/MyFolder/{fileName}", true))
                {
                    try
                    {
                        sw.WriteLine("Region: " + country["region"].ToString());
                        sw.WriteLine("Subregion: " + country["subregion"].ToString());
                        sw.WriteLine("Latlng: " + country["latlng"].ToString());
                        sw.WriteLine("Area: " + country["area"].ToString());
                        sw.WriteLine("Population: " + country["population"].ToString());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message + $"-Country: {country["name"]}");
                        continue;
                    }
                    
                }
            }
            Console.WriteLine("-------------------------End.Please press any key----------------------------");
        }
    }
}

