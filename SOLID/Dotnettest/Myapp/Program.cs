//Solid Principle

//See individual files for code eg
//S= Single responsibility - This principle says that a class has only one reason to change i.e a specific use case.



//Open Closed principle - a class should be open for extension bul closed for modification. . This principle promotes the idea that you should be able to add new functionality to a component without altering its existing code.

//Liskov's substitution principle - It states that object of derived class should be able to replace object of base class without causing any errors in the class

//Interface Segregation Principle- Rather than one fat interface we can use multiple interfaces so that the client is not forced to implement any methods they dont use

//Dependency Inversion Principle-his Principle states that high-level modules/classes should not depend on low-level modules/classes. 
//Both should depend upon abstractions. Secondly, abstractions should not depend upon details. Details should depend upon abstractions.
// In simpler terms, classes should depend on interfaces or abstract classes, not concrete implementations eg - dependency injection


using myinh;

namespace myinh
{
public class Animal
{

    public virtual void dispaly()
    {
        Console.WriteLine("I am an animal");
    }

}


public class Dog : Animal
{
    public new void dispaly()
    {
        Console.WriteLine("I am a dog");
    }

}
}

public class Program
    {
        public static void Main()
        {
        Animal a = new Animal();
        a.dispaly();
        a = new Dog();
        a.dispaly();

            
            Console.ReadKey();
        }
    }
