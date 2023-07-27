using System.Collections.Generic;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Configuration;
using static System.Console;



namespace ruggero61
{
  public class Program
  {
    static void Main(string[] args)
    {
      // Set up configuration builder
      IConfiguration configuration = new ConfigurationBuilder()
          .AddJsonFile( "jsonFiles/appsettings.json", optional: false, reloadOnChange: true)
          .Build();
      
      // Get the value of the "JsonFilePath" configuration setting
      string? jsonFilePath = configuration["JsonFilePath"];
      
      GeneralTest.TestEmployee(jsonFilePath);
      ReadKey();
    }
  }
}