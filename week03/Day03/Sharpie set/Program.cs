using System;

namespace Sharpie_set
{
    class Program
    {
        static void Main(string[] args)
        {
            Sharpie pencil = new Sharpie("red", 5);
            Sharpie tuzka = new Sharpie("blue", 5);
            Sharpie pero = new Sharpie("black", 5);

            SharpieSet psaciSouprava = new SharpieSet();

            psaciSouprava.Add(pencil);
            psaciSouprava.Add(tuzka);
            psaciSouprava.Add(pero);

            pero.Use();
            tuzka.Use();
            psaciSouprava.RemoveTrash();

            psaciSouprava.CountUsable();
            Console.WriteLine(psaciSouprava.GetCount());
        }
    }
}
