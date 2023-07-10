namespace ruggero61
{
  public static class InitEmployeeClass
  {
    public static EmployeesCollection JsonDataToEmployeeClass(string jsonFilePath) => 
      new JsonFileDataToEmployeeClass(jsonFilePath).GetEmployeesFromJsonFile();
  }
}