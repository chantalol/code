using Abstract;
using Bonus1;
using Opdracht5;
using Opdracht6;
using System;
using System.Security.Cryptography.X509Certificates;
using static Opdracht6.Firearm;
class Program
{
    static void Main(string[] args)
    {
        Opdracht6();
    }

    static void opdracht3()
    {

        var car = new Opdracht3.Car("Gas", "Blue");
        car.Move();
        car.Accelerate(100);
        car.honkHorn();

        var bicycle = new Opdracht3.Bicycle("Dirt Bike", "red");
        bicycle.Move();
        bicycle.Accelerate(20);
        bicycle.ringBell();

        var truck = new Opdracht3.Truck("White", 500);
        truck.Move();
        truck.Accelerate(80);
        truck.unloadCargo();

        var ebike = new Opdracht3.Ebike("Black", 30);
        ebike.Move();
        ebike.Accelerate(35);
        ebike.chargeBattery();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static void opdracht2()
    {

        var dog = new Opdracht4.Dog("Milo", 3);
        dog.Eat();
        dog.MakeSound();
        dog.Sleep();

        var cat = new Opdracht4.Cat("Garfield", 2);
        cat.Eat();
        cat.MakeSound();
        cat.Sleep();

        var chicken = new Opdracht4.Chicken("Max", 4);
        chicken.Eat();
        chicken.MakeSound();
        chicken.Sleep();

        var monkey = new Opdracht4.Monkey("Sam", 5);
        monkey.Eat();
        monkey.MakeSound();
        monkey.Sleep();

        var sheep = new Opdracht4.Sheep("Alex", 6);
        sheep.Eat();
        sheep.MakeSound();
        sheep.Sleep();

    }
    static void opdracht5()
    {
        var bike = new Opdracht5.Bike("womp womp");
        bike.Pedal(10);
        bike.Brake(5);

        var ebike = new Bike.Ebike("Giant");
        ebike.Pedal(10);
        ebike.Brake(5);
        ebike.Charging(20);
    }

    static void Opdracht6()
    {
        var ak47 = new AK47(30);
        Console.WriteLine("AK-47 Manufacturing year: " + ak47.GetManufacturingYear());
        Console.WriteLine("AK-47 Shoot damage: " + ak47.Shoot());
        ak47.Reload();

        var bow = new Bow("Crossbow");
        bow.LoadArrow("Fire");
        Console.WriteLine("Bow shoot damage: " + bow.Shoot());
        bow.SwapArrow("Wooden");
        Console.WriteLine("Bow shoot damage: " + bow.Shoot());
    }

    static void Bonus1()
    {
        var boek1 = new Leenbaarboek("Boek", "Harry potter", "Chantal Hu", "Romance", false);
        var boek2 = new Leenbaarboek("Boek", "Okay", "Chantal Hu", "Fantasy", false);
        var boek3 = new Leenbaarboek("Boek", "hahahah", "Chantal Hu", "Fiction", false);

        var lid1 = new Lid(1, "Pieter", "pieter@example.com");
        lid1.BorrowItem(boek1);  
        lid1.BorrowItem(boek2);  
        lid1.BorrowItem(boek1); 
        lid1.ReturnItem(boek1); 
        lid1.ReturnItem(boek3); 

    }
}


    



