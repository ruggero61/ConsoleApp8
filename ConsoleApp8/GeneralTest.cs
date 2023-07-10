namespace ruggero61
{
  public static class GeneralTest
  {
    public static void TestEmployee(string jsonFilePath)
    {
      foreach (var employee in InitEmployeeClass.JsonDataToEmployeeClass(jsonFilePath)) 
        Console.WriteLine($"Employee : {employee._firstName} {employee._lastName} - Department : {employee._department}");
    }
  }
}