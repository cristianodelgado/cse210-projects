using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Ruta 9 km 235", "Villa Maria", "Cordoba", "Argentina");
        Address address2 = new Address("Av Pron 1935", "Villa Maria", "Cordoba", "Argentina");
        Address address3 = new Address("Av Costanera 485", "Carlos Paz", "Cordoba", "Argentina");
    
        Event event1 = new Event("Generic Event 1°", "Generic Event Description 1°", "7/20/2023", "22:00", address1);
        Lecture lecture1 = new Lecture("Lecture 1°", "Lecture Description 1°", "7/9/2023", "10:00 ", address2, "Pedro Sabato", 1000);
        Reception reception1 = new Reception("Reception 1°", "Reception Description 1°", "8/19/2023", "15:00", address3, "municipalidadvm@gmail.com");
        OutdoorGathering outdoorGathering1 = new OutdoorGathering("Outdoor Gathering 1°", "Outdoor Gathering Description 1°", "09/02/2023", "20:00", address1, "Cold");
        
        Console.WriteLine("--- Standard Details ---");
        Console.WriteLine();
        Console.WriteLine(event1.GetStandarDetails());
        Console.WriteLine();
        Console.WriteLine(lecture1.GetStandarDetails());
        Console.WriteLine();
        Console.WriteLine(reception1.GetStandarDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering1.GetStandarDetails());
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("--- Full Details ---");
        Console.WriteLine();
        Console.WriteLine(event1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("--- Short Description ---");
        Console.WriteLine();
        Console.WriteLine(event1.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(lecture1.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(reception1.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering1.GetShortDescription());
    }

}