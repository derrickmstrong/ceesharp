class Animal  // Base class (parent) 
{
  public string name = "Animal";
  public virtual void animalSound() // Virtual from the inherited animalSound()
  {
    Console.WriteLine("The animal makes a sound");
  }
  public void run(string name) // Vehicle method 
  {                    
    Console.WriteLine($"{name} is running...");
  }
}

class Pig : Animal  // Derived class (child) 
{
  public override void animalSound() // Override the inherited animalSound()
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Dog : Animal  // Derived class (child) 
{
  public override void animalSound() // Override the inherited animalSound()
  {
    Console.WriteLine("The dog says: bow wow");
  }
}