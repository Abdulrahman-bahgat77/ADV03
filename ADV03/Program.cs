using System.Collections;

namespace ADV03
{
    internal class Program
    {
        class StringEqualityComparer : IEqualityComparer<string>
        {
            public new bool Equals(string? x, string? y)
            {
                 
                return x?.ToLower().Equals(y?.ToLower()) ?? y is null ? true : false;
            }

            public int GetHashCode(string obj)
            {
                 
                return obj?.ToLower().GetHashCode() ?? 0;
            }
        }
        class StringComparer : IComparer<string>
        {
            public int Compare(string? x, string? y)
            {
                 return y?.CompareTo(x)?? (x is null ? 0 : 1);
            }
        }
        static void Main(string[] args)
        {


            #region Stack
            //Stack<int> stack=new Stack<int> ();
            // stack.Push (1);
            // stack.Push(2);
            // stack.Push(3);
            // Console.WriteLine(stack.Pop());
            // Console.WriteLine(stack.Pop());
            // //Console.WriteLine(stack.Pop());

            // bool result = stack.TryPop(out int element);
            // Console.WriteLine(result);
            // Console.WriteLine(element);
            // Console.WriteLine("-----------");
            //foreach(int i in stack)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Queue
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //Console.WriteLine(queue.Dequeue());

            #endregion


            #region Hash Table
            // Hashtable Note = new Hashtable(new StringEqualityComparer());
            //Note.Add("Abdo", 22);
            ////Note.Add("abdo", 22);
            // Note.Add("Ahmed", 23);
            // Note.Add("mano", 21);
            #region ADD
            //unsafe
            //Note.Add("Abdo", 21);

            //if (!Note.Contains("Abdo"))
            //{
            //    Note.Add("Abdo", 22);
            //}
            #endregion

            #region Get
            //Console.WriteLine(Note["moo"]??  string.Empty);

            //if (Note.Contains("moo"))
            //{
            //    Console.WriteLine(Note["moo"]);
            //}
            #endregion
            //foreach (DictionaryEntry i in Note)
            //{
            //    Console.WriteLine($"{i.Key}:: {i.Value}");
            //}
            #endregion

            #region Generic Collection -Dictionary(Hash Table)
            // Dictionary<string, int> Note = new Dictionary<string, int>(new StringEqualityComparer());
            //  Note.Add("Ahmed", 22);
            //// Note.Add("ahmed", 22);
            // Note.Add("Abdo", 21);
            // Note.Add("Mano", 23);

            #region Add And Update
            ////  Note.Add("Ahmed", 212);//Unsafe code

            ////Protective COde
            //if (!Note.ContainsKey("Ahmed"))
            //    Note.Add("Ahmed", 21);
            //Note.TryAdd("Ahmed", 22);

            //if (!Note.ContainsKey("Abdo"))
            //{
            //    Note.Add("Abdo", 22);
            //}
            //else
            //{
            //    Note["Abdo"] = 22;
            //}

            #endregion

            #region GET
            //  Console.WriteLine(Note["manar"]); //unsafe

            //if (Note.ContainsKey("Manar"))
            //{
            //    Console.WriteLine(Note["manar"]); //unsafe
            //}
            //Note.TryGetValue("Manar", out int value);

            #endregion

            #region Retrive all entry
            //foreach (KeyValuePair<string, int> person in Note)
            //{
            //    Console.WriteLine($"{person.Key}||{person.Value}");
            //}

            //foreach(string Key in Note.Keys)
            //{
            //    Console.WriteLine(Key);
            //}

            //foreach(int Value in Note.Values)
            //{
            //    Console.WriteLine(Value);
            //}
            #endregion

            #endregion

            #region  Generic Collection -SortedDictionary(BST)
            //SortedDictionary<string, int> Note = new SortedDictionary<string, int>(new StringComparer());
            //Note.Add("Omar", 444);
            //Note.Add("Mano", 333);
            //Note.Add("Abdo", 222);

            //foreach (KeyValuePair<string,int> Person in Note)
            //{
            //    Console.WriteLine($"{Person.Key}||{Person.Value}");
            //}

            //SortedDictionary<Employee, string> Employees = new SortedDictionary<Employee, string>(new EmployeeComparerAsc());

            //Employees.Add(new Employee(1, "Abdo", 20000), "1::Abdo::20000$");
            //Employees.Add(new Employee(2, "Mano", 30000), "2::Mano::30000$");
            //Employees.Add(new Employee(3, "moo", 10000), "moo::moo::10000");

            //foreach(var Employee in Employees)
            //{
            //    Console.WriteLine(Employee.Key);
            //}
            #endregion

            #region  Generic Collection -SortedList(TwoArray)
            //SortedList<string, int> Notee = new SortedList<string, int>(Note,new StringComparer());
            // //Note.Add("Zoo", 444);
            // //Note.Add("Mano", 333);
            // //Note.Add("Abdo", 222);
            //foreach(var person in Notee)
            //{
            //    Console.WriteLine($"{person.Key}::{person.Value}");
            //}
            #endregion

            #region  Generic Collection -HashSet(HashTable)
            //HashSet<int> Numbers = new HashSet<int>();

            //Numbers.Add(1);
            //Numbers.Add(2);
            //Numbers.Add(3);
            //Numbers.Add(4);
            //foreach (int i in Numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //HashSet<Movie> movies = new HashSet<Movie>()
            //{
            //    new Movie(1,"spiderman",120),
            //    new Movie(2,"BatMan",200),
            //    new Movie(3,"superman",150),
            //};

            //foreach (Movie movie in movies)
            //{
            //    Console.WriteLine(movie);
            //}

            #region HashSet Methods
            // HashSet<int> Numbers01 = new HashSet<int>() { 1,2,3,4,5};
            // HashSet<int> Numbers02 = new HashSet<int>() { 1, 2, 3, 4, 5 };
            // Numbers01.TryGetValue(22, out int result);
            // Console.WriteLine(result);
            // Numbers02.ExceptWith(Numbers01);
            //Numbers02.SymmetricExceptWith(Numbers01);
            //Console.WriteLine(Numbers01.IsSubsetOf(Numbers02)); 
            //Console.WriteLine(Numbers01.IsProperSubsetOf(Numbers02));
            // Console.WriteLine(Numbers01.Overlaps(Numbers02));
            //foreach (int i in Numbers02)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #endregion

            #region  Generic Collection -SortedSet(BBST)
            //  SortedSet<int> Numbers = new SortedSet<int>();
            //  Numbers.Add(15);
            //  Numbers.Add(1);
            //  Numbers.Add(4);
            //  Numbers.Add(2);
            //  Numbers.Add(2);

            //foreach (int i in Numbers)
            //  {
            //      Console.WriteLine(i);
            //  }
            #endregion
        }
    }

    
}
