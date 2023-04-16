class Car 
{
  public string model; // field
  public string color; // field
  public string seats; // field
  public int year; // field
  private string name; // private field only accessible within this class
  public void fullThrottle(string car) // method
  {
    Console.WriteLine($"The {car} is going as fast as it can!"); 
  }

  // Create a class constructor for the Car class with a parameter
  public Car(string modelName, string colorName, string seatsName, int yearName)
  {
    model = modelName;
    color = colorName;
    seats = seatsName;
    year = yearName;
    name = "Betty";
  }
  public string Name   // property created to use private field in different class
  {
    get { return name; } // required to use private field 
    set { name = value; } // required to use private field 
    // { get; set; } // Alternative to 2 lines above
  }
}

