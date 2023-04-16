// See https://aka.ms/new-console-template for more information
// Run program in Terminal: dotnet run
using System;
using System.Linq;

namespace HelloWorld
{
  class Program
  {
    // Methods
    // MyName() is the name of the method
    // static means that the method belongs to the Program class and not an object of the Program class. You will learn more about objects and how to access methods through objects later in this tutorial.
    // void means that this method does not have a return value. You will learn more about return values later in this chapter
    static void MyName(string fname = "Derrick", string lname = "Strong")
    {
      Console.WriteLine($"My name is {fname} {lname}.");
    }

    static int PlusFive(int x = 0)
    {
      return 5 + x;
    }

    static int PlusMethod(int x, int y)
    {
      return x + y;
    }

    static double PlusMethod(double x, double y)
    {
      return x + y;
    }

    static void Main()
    {
      // Hello World
      Console.WriteLine("Hello DS!");

      // Read/Use user input
      Console.WriteLine("How old are you?");
      int input = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine($"You are {input} years old!");

      // Create Variables
      string petName = "Shadow";
      string breed = "Golden Retriever";
      int age = 5;
      double trueWeight = 65.22;
      bool spayed = true;
      // Print variables to the console
      Console.WriteLine(petName);
      Console.WriteLine(breed);
      Console.WriteLine(age);
      Console.WriteLine(trueWeight);
      Console.WriteLine(spayed);

      // Type conversion
      int weight = (int)trueWeight;
      double trueAge = Convert.ToDouble(age);
      string firstName = "Derrick ";
      string lastName = "Strong";
      Console.WriteLine(weight);
      Console.WriteLine(trueAge);
      // Ask user for fave number
      Console.Write("Enter your favorite number: ");
      // Turn that answer into an int - Console.Readline() output will always be a string unless you convert it
      int faveNumber = Convert.ToInt32(Console.ReadLine());

      // Change a string to a list of chars
      foreach (var chars in firstName)
      {
        Console.WriteLine(chars);
      }

      // Write Method
      Console.Write("Hello World! ");
      Console.Write("I will print on the same line. \n");

      // Overriding variable
      int myNum = 15;
      myNum = 20; // myNum is now 20
      Console.WriteLine(myNum);

      // Constants
      // const int myInt = 25;
      // myInt = 30; // Error; Can not override a constant

      // Declare multiple variables
      int x = 5, y = 6, z = 50;
      Console.WriteLine(x + y + z);

      int xX, yY, zZ;
      xX = yY = zZ = 50;
      Console.WriteLine(xX + yY + zZ);

      // Float vs Double
      float f1 = 35.7989808909e3F;
      double d1 = 12.39038939203909209032E10D;
      Console.WriteLine(f1);
      Console.WriteLine(d1);

      // Implicit Casting
      int myIntImplicit = 9;
      double myDouble = myIntImplicit; // Automatic casting: int to double
      Console.WriteLine(myIntImplicit); // Outputs 9
      Console.WriteLine(myDouble); // Outputs 9

      // Explicit Casting
      double myDoubleExplicit = 9.78;
      int myIntExplicit = (int) myDoubleExplicit; // Manual casting: double to int
      Console.WriteLine(myDoubleExplicit); // Outputs 9.78
      Console.WriteLine(myIntExplicit); // Outputs 9

      // Built-In Conversion Types
      int myIntConversion = 10;
      double myDoubleConversion = 5.25;
      bool myBoolConversion = true;
      Console.WriteLine(Convert.ToString(myIntConversion)); // convert int to string
      Console.WriteLine(Convert.ToDouble(myIntConversion)); // convert int to double
      Console.WriteLine(Convert.ToInt32(myDoubleConversion)); // convert double to int
      Console.WriteLine(Convert.ToString(myBoolConversion)); // convert bool to string

      // Math functions
      Console.WriteLine(Math.Max(5, 10));
      Console.WriteLine(Math.Min(5, 10));
      Console.WriteLine(Math.Sqrt(64));
      Console.WriteLine(Math.Abs(-6.4));
      Console.WriteLine(Math.Round(9.99));

      // String functions
      string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      Console.WriteLine("The length of the txt string is: " + txt.Length);

      txt = "Hello World";
      Console.WriteLine(txt.ToUpper()); // Outputs "HELLO WORLD"
      Console.WriteLine(txt.ToLower()); // Outputs "hello world"

      string fullName = string.Concat(firstName, lastName);
      Console.WriteLine(fullName);

      // String Interpolation
      string fullName2 = $"My full name is: {firstName}{lastName}";
      Console.WriteLine(fullName2);

      // Access Strings
      string myString2 = "Hello";
      Console.WriteLine(myString2[0]);
      Console.WriteLine(myString2.IndexOf("e"));

      // Location of the letter D
      int charPos = fullName.IndexOf("S");
      // Get last name
      string lastName2 = fullName.Substring(charPos);
      // Print the result
      Console.WriteLine(lastName2);

      // Booleans
      int myAge = 43;
      const int votingAge = 18;

      if (myAge >= votingAge)
      {
        Console.WriteLine("Old enough to vote");
      }
      else
      {
        Console.WriteLine("Not old enough to vote");
      }

      // Ternary Operator
      int time = 20;
      string result = (time < 18) ? "Good day." : "Good evening.";
      Console.WriteLine(result);

      // Switch statement
      int day = 5;
      switch (day)
      {
        case 1:
        Console.WriteLine("Sunday");
        break;
        case 2:
        Console.WriteLine("Monday");
        break;
        case 3:
        Console.WriteLine("Tuesday");
        break;
        case 4:
        Console.WriteLine("Wednesday");
        break;
        case 5:
        Console.WriteLine("Thursday");
        break;
        case 6:
        Console.WriteLine("Friday");
        break;
        case 7:
        Console.WriteLine("Saturday");
        break;
        default:
        Console.WriteLine("Invalid value");
        break;
      }

      // While loop
      int i = 0;
      while (i < 5) 
      {
        Console.WriteLine(i);
        i++;
      }

      // Do While loop
      i = 5;
      do 
        {
          Console.WriteLine(i);
          i++;
        }
        while (i < 5);

      // For loop
      for (int count = 0; count < 5; count++) 
      {
        Console.WriteLine(count);
      }

      // (Nested) For loop
      for (int xCount = 1; xCount <= 2; xCount++)
      {
        Console.WriteLine($"Outer Loop: {xCount}");
        for (int yCount = 1; yCount <= 3; yCount++)
        {
          Console.WriteLine($"Inner Loop: {yCount}");
        }
      }

      // Foreach loop (used on arrays)
      string[] cars = {"Volvo", "Honda", "Nissan", "Toyota"}; // Array
      foreach (string c in cars)
      {
        Console.WriteLine(c);
      }

      // Break
      for (int breakpoint = 0; breakpoint < 10; breakpoint++) 
      {
        if (breakpoint == 4) 
        {
          break;
        }
        Console.WriteLine(breakpoint);
      }

      // Continue
      for (int continuepoint = 0; continuepoint < 10; continuepoint++) 
      {
        if (continuepoint == 4) 
        {
          continue;
        }
        Console.WriteLine(continuepoint);
      }

      // Break While
      int breakWhile = 0;
      while (breakWhile < 10) 
      {
        Console.WriteLine(breakWhile);
        breakWhile++;
        if (breakWhile == 4) 
        {
          break;
        }
      }

      // Continue While
      int continueWhile = 0;
      while (continueWhile < 10) 
      {
        if (continueWhile == 4) 
        {
          continueWhile++;
          continue;
        }
        Console.WriteLine(continueWhile);
        continueWhile++;
      }

      // Ways to setup an array
      // Create an array of four elements, and add values later
      string[] carList = new string[4];

      // Create an array of four elements and add values right away 
      string[] carList2 = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

      // Create an array of four elements without specifying the size 
      string[] carList3 = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

      // Create an array of four elements, omitting the new keyword, and without specifying the size
      string[] carList4 = {"Volvo", "BMW", "Ford", "Mazda"};

      // Arrays
      string[] myCars = {"Volvo", "BMW", "Ford", "Mazda"};

      Console.WriteLine($"I have {myCars.Length} cars.");
      Console.WriteLine($"My favorite is the {myCars[1]}.");
      myCars[2] = "Maybach";

      // Sort Method
      Array.Sort(myCars);

      // Loop through array
      foreach (string car in myCars)
      {
        Console.WriteLine(car);
      }

      // System.Linq Namespace
      int[] myNums = {5, 1, 8, 9};
      Console.WriteLine(myNums.Max());
      Console.WriteLine(myNums.Min());
      Console.WriteLine(myNums.Sum());

      // Multi-dimensional arrays
      int[,] myNumbers = { {1, 4, 2}, {3, 6, 8} };
      // Change element in 2D array
      myNumbers[1, 1] = 7;

      // Access elements in a 2D array
      Console.WriteLine(myNumbers[1, 1]);

      // Loop through 2D array
      foreach(int myNumber in myNumbers)
      {
        Console.WriteLine(myNumber);
      }

      // Methods/Functions
      MyName();
      MyName("Malone");
      MyName(lname: "Davon", fname: "Dionycio");

      Console.WriteLine(PlusFive());
      Console.WriteLine(PlusFive(2));

      // Methods (Overloading)
      int myNum1 = PlusMethod(8, 5);
      double myNum2 = PlusMethod(4.3, 6.26);
      Console.WriteLine("Int: " + myNum1);
      Console.WriteLine("Double: " + myNum2);

      // Creating new instance (object) of the Car class (Car.cs) and assigning an attribute
      Car Honda = new Car("Accord", "grey", "leather", 1997);
      Console.WriteLine($"My first vehicle was a {Honda.color} {Honda.model} with {Honda.seats} seats.");
      Console.WriteLine(Honda.model);
      // Honda.honk();

      Car Toyota = new Car("Camry", "green", "cloth", 2000);
      Console.WriteLine(Toyota.Name); // Calling private field from different class
      Console.WriteLine($"My first vehicle was a {Toyota.color} {Toyota.model} with {Toyota.seats} seats.");
      Toyota.model = "4Runner"; // Change model

      Console.WriteLine(Toyota.model);
      Toyota.fullThrottle(Toyota.model);

      Vehicle Veronica = new Vehicle();
      Console.WriteLine(Veronica.brand);
      Veronica.honk();

      Animal myAnimal = new Animal();  // Create a Animal object
      Animal myPig = new Pig();  // Create a Pig object
      Animal myDog = new Dog();  // Create a Dog object

      myAnimal.animalSound();
      myPig.animalSound();
      myDog.animalSound();

      myDog.run(myDog.name);

      // Interface
      Rabbit myRabbit = new Rabbit();  // Create a Rabbit object
      Elephant myElephant = new Elephant();  // Create a Elephant object

      myRabbit.animalVoice();
      myElephant.animalVoice();

      // Enum
      Level med = Level.Medium;
      Console.WriteLine(med);

      int aug = (int) Months.August;
      Console.WriteLine(aug);

      // Files
      string writeText = "Hello World!";  // Create a text string
      File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

      string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
      Console.WriteLine(readText);  // Output the content
      
      // Exception
      try
      {
        int[] myNewArray = {1, 2, 3};
        Console.WriteLine(myNewArray[10]);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
      finally
      {
        Console.WriteLine("The 'try catch' is finished.");
      }
    }
  }
}