using System.Text;
using System.Threading.Tasks;

namespace ADV03
{
    class EmployeeComparerAsc : IComparer<Employee>
    {
        
        public int Compare(Employee? x, Employee? y)
        {
            return x?.CompareTo(x) ?? (y is null ? 0 : -1);
        }
    }
    class EmployeeComparerDesc : IComparer<Employee>
    {

        public int Compare(Employee? x, Employee? y)
        {
            return y?.CompareTo(x) ?? (x is null ? 0 : -1);
        }
    }
   
    internal class Employee:IComparable<Employee>
    {
       

        public Employee(int id, string? name, int salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Employee? other)
        {
            return  this.Salary.CompareTo(other?.Salary);
        }

        public override string ToString()
        
            => $"Id:{Id}::Name:{Name}::Salary{Salary}" ;
       
    }
}
