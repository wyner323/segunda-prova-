using System;

class Program
{
    static void Main()
    {
        string entrada1 = Console.ReadLine();
        string entrada2 = Console.ReadLine();
        string entrada3 = Console.ReadLine();
        string resultado = "";

        if (entrada1 == "vertebrado")
        {
            if (entrada2 == "ave")
            {
                if (entrada3 == "carnivoro")
                    resultado = "AGUIA";
                else if (entrada3 == "onivoro")
                    resultado = "POMBA";
            }
            else if (entrada2 == "mamifero")
            {
                if (entrada3 == "onivoro")
                    resultado = "HOMEM";
                else if (entrada3 == "herbivoro")
                    resultado = "VACA";
            }
        }
        else if (entrada1 == "invertebrado")
        {
            if (entrada2 == "inseto")
            {
                if (entrada3 == "hematofago")
                    resultado = "PULGA";
                else if (entrada3 == "herbivoro")
                    resultado = "LAGARTA";
            }
            else if (entrada2 == "anelideo")
            {
                if (entrada3 == "hematofago")
                    resultado = "SANGUESSUGA";
                else if (entrada3 == "onivoro")
                    resultado = "MINHOCA";
            }
        }

        Console.WriteLine(resultado);
    }
}