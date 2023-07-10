namespace ruggero61
{
  public class JsonFileDataToEmployeeClass
  { 
    private string _jsonFilePath;
    private FileManager _fileManager;

    public JsonFileDataToEmployeeClass(string jsonFilePath) 
    {
      _jsonFilePath = jsonFilePath;
      _fileManager = new FileManager(jsonFilePath);
    }

    public EmployeesCollection GetEmployeesFromJsonFile() => 
      new EmployeesCollection(_fileManager.GetEmployeesFronJsonFile());
  }
  public class JsonFileDataToClass
  { 
    private string _jsonFilePath;
    private FileManager _fileManager;

    public JsonFileDataToClass(string jsonFilePath) 
    {
      _jsonFilePath = jsonFilePath;
      _fileManager = new FileManager(jsonFilePath);
    }

    public EmployeesCollection GetEmployeesFromJsonFile() => 
      new EmployeesCollection(_fileManager.GetEmployeesFronJsonFile());
  }
}