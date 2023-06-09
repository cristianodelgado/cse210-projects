using System;

class Program
{
    static void Main(string[] args)
    {
        
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start Listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu:");
            int opcion = int.Parse(Console.ReadLine());
            Activity actividad;
        
            switch (opcion)
            {
                case 1:
                    actividad = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
                    break;
                case 2:
                    actividad = new ReflectingActivity("Reflecting activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    break;
                case 3:
                    actividad = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    
                    break;
                case 4:
                    Console.WriteLine("Bye");
                    quit = true;
                    return;
                default:
                    Console.WriteLine("You have entered an invalid option.");
                    return;
            }
        
            actividad.Ejecutar();
        }
        
    }
}