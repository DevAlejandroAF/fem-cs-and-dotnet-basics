using System.Collections;

internal class Program
{
  private static void Main(string[] args)
  {
    /*
     * Variable types
     */

    // Numeric
    int intVar = 5;
    short shortVar = 32767;
    long longVar = 46192651568;

    // Unsigned
    uint uintVar = 142314;
    ushort ushortVar = 3142;
    ulong ulongVar = 2152138501238;

    // Floating
    float floatVar = 13.5f;
    double doubleVar = 1535125.8343;
    decimal decimalVar = 324.12252345836598m;

    // Boolean
    bool booleanVar = true;

    // Char
    char charVar = 'A';

    // string
    string stringVar = "John";
    string multiLine = """
      multiLine
      String
      """;
    string message = $"Hello, {stringVar}";
    string emptyString = string.Empty; // Same as ""
    // some methods: string.IsNullOrEmpty - string.IsNullOrWhiteSpace - string.Equals(string a, string b, StringComparison)

    // const
    const int MaxScore = 100;

    // interpretate type
    var someVar = "Hello";
    var employeeType = EmployeeType.Manager;

    // Arrays
    int[] fixedArray = new int[5];
    int[] nums = [1, 2, 3];
    string[] fruits;
    ArrayList arrayList = new ArrayList();
    var list = new List<string>();
    List<int> numbersList = new List<int> { 1, 2, 3 };
    List<int> numbersList2 = [1, 2, 3];
    var dict = new Dictionary<string, int>();


    // Date
    DateTime dateVar = DateTime.UtcNow;

    // Tuples
    var tupleVar = (12, "Hello", true);
    var tupleVar2 = (Age: 12, Name: "John", IsEmployed: true);
    (string, int) tupleVar3 = ("Age", 17);
    // Console.WriteLine(tupleVar.Item1); // Output: 12
    // Console.WriteLine(tupleVar2.Age); // Output: 12

    // Default
    int defaultValue = default; // Output: 0

    // Nullable
    int? nullable = null;

    /*
     * Control flow
     */

    // If
    ushort age = 17;
    if (age >= 18)
    {
      Console.WriteLine("[+] Allowed!");
    }
    else if (age < 0)
    {
      Console.WriteLine("[x] Error");
    }
    else
    {
      Console.WriteLine("[!] Not Allowed");
    }

    // Switch
    ushort day = 3;
    switch (day)
    {
      case 1:
        Console.WriteLine("Monday");
        break;
      case 2:
        Console.WriteLine("Tuesday");
        break;
      case 3:
        Console.WriteLine("Wednesday");
        break;
      case 4:
        Console.WriteLine("Thursday");
        break;
      case 5:
        Console.WriteLine("Friday");
        break;
      case 6:
        Console.WriteLine("Saturday");
        break;
      case 7:
        Console.WriteLine("Sunday");
        break;
      default:
        Console.WriteLine("[!] Invalid Day");
        break;
    }

    /*
     * Loops
     */

    // For
    int result = 0;
    for (int i = 0; i < nums.Length; i++)
    {
      result += nums[i];
    }

    // ForEach
    foreach (var e in Enum.GetValues(typeof(EmployeeType)))
    {
      Console.WriteLine(e);
    }

    // while
    while (true)
    {
      break;
    }

    // Do while
    /*
    do {

    } while (condition);
    /*

    /*
     * Exceptions
     */

    try
    {
      DateTime.Parse("123");
    }
    catch (Exception ex)
    {
      Console.WriteLine("[!] Something went wrong!");
      Console.WriteLine(ex);
      // throw;
      // throw new ...;
    }
    finally
    {
      Console.WriteLine("Always executed");
    }

    /*
     * type pattern
     */

    object value = "Hello, World!";
    if (value is string str) // like typeOf in js
    {
      Console.WriteLine($"The value es a string: {str}");
    }
    else
    {
      Console.WriteLine("The value is not a string.");
    }

    /*
     * Cast/Conversion
     */

    int a = 5;
    double b = (double)a;
    double c = Convert.ToDouble(a);
    string textBox = "55";
    var ageParse = int.Parse(textBox);
    var tryParse = int.TryParse(textBox, out ageParse); // the variable can be declare in the result

    /*
     * Local Functions
     */

    int Add(int x, int y)
    {
      return x + y;
    }

    // Lambda
    Func<int, int, int> Add2 = (x, y) => x + y; // <parameter types..., return type>

    /*
     * Print
     */

    Console.WriteLine("Hello, World!");

    Console.WriteLine(Math.AddNumbers(5, 8));
    Console.WriteLine(Math.AddNumbers(1, 2, 3, 4));
    PrintMessage("Hi!");
    Console.WriteLine(IsEven(4));
  }

  // Enums
  enum EmployeeType
  {
    Manager,
    Supervisor,
    Worker
  }

  /* Especific order
  enum EmployeeType
  {
    Manager = 1,
    Supervisor = 3,
    Worker = 2
  }
  int employeeType = (int) EmployeeType.Manager; // Output: 1
  */

  /*
   * Methods/Functions
   */

  public static class Math
  {
    public static int AddNumbers(int a, int b)
    {
      return a + b;
    }

    // Overload Methods
    public static int AddNumbers(int a, int b, int c)
    {
      return a + b + c;
    }

    // multiple parameters (must be the last one parameter)
    public static int AddNumbers(params int[] numbers)
    {
      int result = 0;
      for (int i = 0; i < numbers.Length; i++)
      {
        result += numbers[i];
      }
      return result;
    }
  }

  public static void PrintMessage(string message)
  {
    Console.WriteLine(message);
  }

  public static bool IsEven(int number)
  {
    if (number % 2 == 0)
    {
      return true;
    }
    return false;
  }

  /*
   * Classes
   */

  public class Person
  {
    public string Name { get; } // inmutable property (no set)
    public string LastName { get; private set; } // mutable inside class property (private set)
    public int Age { get; set; } // Mutable property
    public string FullName => $"{Name} {LastName}"; // Computed property

    // Constructor
    public Person(string name, string lastName)
    {
      if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(lastName))
      {
        throw new ArgumentException("Name or LastName cannot be null or empty");
      }
      Name = name;
      LastName = lastName;
    }

    public Person(string name, string lastName, int age) : this(name, lastName) // Call the other constructor with two properties
    {
      Age = age;
    }

    // Methods
    public void SetLastName(string lastName)
    {
      LastName = lastName;
    }
  }

  // Inheritance
  public class BaseEmployee
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public virtual string GetEmployeeDetails() // To override a method is necessary the virtual keyword, and sealed keyword is used to avoid override in other classes
    {
      return $"{FirstName} {LastName}";
    }
  }

  public class Employee : BaseEmployee
  {
    public decimal HourlyRate { get; set; }

    public Employee(decimal hourlyRate)
    {
      HourlyRate = hourlyRate;
    }

    public decimal CalculateWeeklyPay(int hoursWorked)
    {
      return HourlyRate * hoursWorked;
    }

    public override string GetEmployeeDetails()
    {
      return base.GetEmployeeDetails() + $" - rate {HourlyRate}";
    }
  }

  /*
   * Like Java in C# exists abstracts classes to implement abstracts methods
   */

  /*
   * Interfaces
   */

  public interface IDatabase // Interfaces must start with capital I
  {
    void Connect();
    void Disconnect();
    bool IsConnected { get; }
  }

  public class MicrosoftSqlServerDatabase : IDatabase
  {
    public bool IsConnected { get; private set; }

    public void Connect()
    {
      // ...
      IsConnected = true;
    }

    public void Disconnect()
    {
      // ...
      IsConnected = false;
    }
  }

  /*
   * Generics
   */

  public class Utilities
  {
    public T GetDefaultValue<T>()
    {
      return default(T);
    }
  }
}
