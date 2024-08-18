using System;
using System.Collections.Generic; //list sınıfını kullanabilmek için bu namespace'si ekliyoruz

class Program
{
    public static void Main()
    {
        List <string> davetliler = new List <string> ();

        //listeye davetli ekle
        davetliler.Add("Bülent Ersoy");
        davetliler.Add("Ajda Pekkan");
        davetliler.Add("Ebru Gündeş");
        davetliler.Add("Hadise");
        davetliler.Add("Hande Yener");
        davetliler.Add("Tarkan");
        davetliler.Add("Funda Arar");
        davetliler.Add("Demet Akalın");

        foreach (string davetli in davetliler)
        {
            Console.WriteLine (davetli);
        }
    }
}

