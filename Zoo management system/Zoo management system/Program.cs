using System;

// Animal (Abstract Class)
abstract class Animal
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string Type { get; set; }

    // Abstract Methods
    public abstract void MakeSound();
    public abstract void Move();
    public abstract void DisplayInfo();
}

interface IMammal
{
    void Relation();
}


// Mammal (Derived from Animal)
class Mammal : Animal,IMammal
{
    // Additional Properties
    public string FurColor { get; set; }
    public bool IsWarmBlooded { get; set; }

    // Implementing Abstract Methods
    public override void MakeSound()
    {
        Console.WriteLine("Mammal makes sound.");
    }

    public override void Move()
    {
        Console.WriteLine("Mammal moves using its legs.");
    }

    public override void DisplayInfo()
    {
        
        Console.WriteLine("Name: {Name}, Age: {Age}, Gender: {Gender}, Type: {Type}");
        Console.WriteLine($"Fur Color: {FurColor}, Warm-Blooded: {IsWarmBlooded}");
    }

    public void Relation()
    {
        Console.WriteLine("I belong to animal family");
    }


}

// Bird (Derived from Animal)
class Bird : Animal
{
    // Additional Properties
    public double WingSpan { get; set; }
    public bool CanFly { get; set; }

    // Implementing Abstract Methods
    public override void MakeSound()
    {
        Console.WriteLine("Bird chirps and tweets.");
    }

    public override void Move()
    {
        Console.WriteLine("Bird flies using its wings.");
    }

    public void Message()
    {
        Console.WriteLine("Message");
    }
    public void Message(string Message)
    {
        Console.WriteLine(Message);
    }

    public int Message(int a ,int b)
    {
        int sum = a + b;
        Console.WriteLine(sum);
        return sum;



    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}, Type: {Type}");
        Console.WriteLine($"Wing Span: {WingSpan} cm, Can Fly: {CanFly}");
    }
}

// Reptile (Derived from Animal)
class Reptile : Animal
{
    // Additional Properties
    public string ScaleColor { get; set; }
    public bool IsColdBlooded { get; set; }

    // Implementing Abstract Methods
    public override void MakeSound()
    {
        Console.WriteLine("Reptile hisses and slithers.");
    }

    public override void Move()
    {
        Console.WriteLine("Reptile crawls on its belly.");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}, Type: {Type}");
        Console.WriteLine($"Scale Color: {ScaleColor}, Cold-Blooded: {IsColdBlooded}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Polymorphism using Abstract Class
        
        Mammal mammal = new Mammal



        {
            Name = "Lion",
            Age = 5,
            Gender = "Male",
            Type = "Mammal",
            FurColor = "Yellow",
            IsWarmBlooded = true
        };


        Bird bird = new Bird
        {
            Name = "Eagle",
            Age = 3,
            Gender = "Female",
            Type = "Bird",
            WingSpan = 180,
            CanFly = true
        };

        Animal reptile = new Reptile
        {
            Name = "Snake",
            Age = 2,
            Gender = "Female",
            Type = "Reptile",
            ScaleColor = "Green",
            IsColdBlooded = true
        };

        Console.WriteLine("Mammal Information:");
        mammal.DisplayInfo();
        mammal.MakeSound();
        mammal.Move();
        mammal.Relation();
       
        //IMammal mammal1;
        //mammal1=mammal;
        //mammal1.Relation();






        Console.WriteLine("\nBird Information:");
        bird.DisplayInfo();
        bird.MakeSound();
        bird.Move();
        bird.Message();
        bird.Message("string");
        bird.Message(3, 3);

        Console.WriteLine("\nReptile Information:");
        reptile.DisplayInfo();
        reptile.MakeSound();
        reptile.Move();
    }
}
