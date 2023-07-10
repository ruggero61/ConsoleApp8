using System.Collections;

namespace ruggero61
{
  public class EmployeesCollection : IList<Employee>
  {
    private List<Employee> _employees = new List<Employee>();

    public EmployeesCollection(List<Employee> employees)
    {
      _employees = employees;
    }

    public Employee this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public int Count => throw new NotImplementedException();

    public bool IsReadOnly => throw new NotImplementedException();

    public void Add(Employee item)
    {
      throw new NotImplementedException();
    }

    public void Clear()
    {
      throw new NotImplementedException();
    }

    public bool Contains(Employee item)
    {
      throw new NotImplementedException();
    }

    public void CopyTo(Employee[] array, int arrayIndex)
    {
      throw new NotImplementedException();
    }

    public IEnumerator<Employee> GetEnumerator()
    {
      foreach (var item in _employees)
      {
        yield return item;
      }
    }

    public int IndexOf(Employee item)
    {
      throw new NotImplementedException();
    }

    public void Insert(int index, Employee item)
    {
      throw new NotImplementedException();
    }

    public bool Remove(Employee item)
    {
      throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
      throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return this.GetEnumerator();
    }
  }


}