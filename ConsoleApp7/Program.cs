using System;

namespace LightStrikeSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Light Strike Simulation!");

            // Введення висоти та швидкості світла
            double height = 100000; // Висота в метрах
            double speedOfLight = 299792458; // Швидкість світла в м/с

            // Розрахунок часу, за який світло долетить до землі
            double time = height / speedOfLight;

            // Виведення відстані, на яку світло вдарило
            double distance = speedOfLight * time;
            Console.WriteLine($"The light struck the ground at a distance of {distance} meters.");

            Console.WriteLine("Simulation complete. Press any key to exit.");
            Console.ReadKey();
        }
    }
}