using System;

public class Animal
{
    public string food;
    public string location;
    public string name;

    public virtual void MakeNoise()
    {
        Console.WriteLine("Животное издает звук.");
    }

    public virtual void Eat()
    {
        Console.WriteLine("Животное кушает.");
    }

    public void Sleep()
    {
        Console.WriteLine("Животное спит.");
    }
}

public class Dog : Animal
{
    public string breed;

    public override void MakeNoise()
    {
        Console.WriteLine("Собака лает.");
    }

    public override void Eat()
    {
        Console.WriteLine("Собака ест кость.");
    }
}

public class Cat : Animal
{
    public string gender;

    public override void MakeNoise()
    {
        Console.WriteLine("Кошка мяучит.");
    }

    public override void Eat()
    {
        Console.WriteLine("Кошка ест рыбу.");
    }
}

public class Horse : Animal
{
    public string color;

    public override void MakeNoise()
    {
        Console.WriteLine("Лошадь ржет.");
    }

    public override void Eat()
    {
        Console.WriteLine("Лошадь ест сено.");
    }
}

public class Veterinarian
{
    public void TreatAnimal(Animal animal)
    {
        Console.WriteLine($"Корм: {animal.food}, Локация: {animal.location}");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.food = "Кость";
        dog.location = "конура";
        dog.breed = "Такса";

        Cat cat = new Cat();
        cat.food = "Рыба";
        cat.location = "квартира";
        cat.gender = "кошка";

        Horse horse = new Horse();
        horse.food = "Сено";
        horse.location = "ферма";
        horse.color = "Белая";

        Veterinarian vet = new Veterinarian();

        vet.TreatAnimal(dog);
        vet.TreatAnimal(cat);
        vet.TreatAnimal(horse);
    }
}
