using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Boş bir kahve listesi oluşturuyoruz
        List<string> kahveler = new List<string>();

        // Kullanıcıdan 5 kahve ismi girmesini istiyoruz
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Kahve {i}: ");
            string kahve = Console.ReadLine();
            kahveler.Add(kahve);  // Kullanıcının girdiği kahveyi listeye ekliyoruz
        }

        // Kahveleri ekrana yazdırıyoruz
        Console.WriteLine("\nKahve Listesi:");
        foreach (string kahve in kahveler)
        {
            Console.WriteLine(kahve);
        }
    }
}

