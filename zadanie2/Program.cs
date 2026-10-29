using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> plecak = new List<string>
        {
            "Miecz",
            "Mikstura",
            "Pochodnia"
        };

        Console.WriteLine("Liczba przedmiotów: " + plecak.Count);
        Console.WriteLine("\nZawartość plecaka:");

        for (int i = 0; i < plecak.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + plecak[i]);
        }

        Console.WriteLine("\nPodaj nazwę nowego przedmiotu:");
        string nowyPrzedmiot = Console.ReadLine();

        plecak.Add(nowyPrzedmiot);

        Console.WriteLine("Dodano przedmiot: " + nowyPrzedmiot);

        if (plecak.Contains("Mikstura"))
        {
            Console.WriteLine("\nW plecaku znajduje się Mikstura.");
        }
        else
        {
            Console.WriteLine("\nW plecaku nie ma Mikstury.");
        }

        bool usunieto = plecak.Remove("Mikstura");

        if (usunieto)
        {
            Console.WriteLine("Usunięto Miksturę z plecaka.");
        }
        else
        {
            Console.WriteLine("Nie udało się usunąć Mikstury.");
        }

        Console.WriteLine("\nAktualna zawartość plecaka:");

        for (int i = 0; i < plecak.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + plecak[i]);
        }

        Console.WriteLine("Liczba przedmiotów po zmianach: " + plecak.Count);
    }
}
