// Created by: Jaejun Lee
// Created on: Mar 2022
//
// This program accepts user input
using System;
class Program
{
    public static void Main(string[] args)
    {
        int length;
        int width;
        int area;
        Console.WriteLine("This program calculates the area of a triangle.");
        Console.WriteLine("");
        Console.Write("Enter the base (cm): ");
        length = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height (cm): ");
        width = Convert.ToInt32(Console.ReadLine());
        area = (length * width) / 2;
        Console.WriteLine("");
        Console.Write("The area of the triangle = " + area + " cm²");
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}