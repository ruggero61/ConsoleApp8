using System.Collections.Generic;
using Newtonsoft.Json;

namespace ruggero61
{
  public class FileManager
  {
    private string _jsonFilePath;
    public FileManager(string jsonFilePath)
    {
      _jsonFilePath = jsonFilePath;
    }

    public List<Employee>? GetEmployeesFromJsonFile()
      => File.Exists(_jsonFilePath)
         ? JsonConvert.DeserializeObject<List<Employee>>(File.ReadAllText(_jsonFilePath))
         : throw new FileNotFoundException($"JSON File not found: {_jsonFilePath}");
  }
}