interface IAnimal
{
    void animalVoice();
}

class Rabbit : IAnimal
{
    public void animalVoice()
    {
        Console.WriteLine("Ribbit...");
    }
}

class Elephant : IAnimal
{
    public void animalVoice()
    {
        Console.WriteLine("Errraaarr...");
    }
}