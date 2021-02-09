using System;
using System.Text;

namespace Pstring2
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "Teste de inversao de frase sem o uso do reverse";
            StringBuilder reversao = new StringBuilder();
            int length = frase.Length -1;
            while(length >= 0)
            {
                 reversao.Append(frase[length]);
                 length--;
            }
            Console.WriteLine($"String original: {frase}");
            Console.WriteLine($"String invertida {reversao}");

            for(int i= frase.Length -1; i >= 0; i--)
            {
                reversao.Append(frase[i]);
            }
            Console.WriteLine($"String invertida {reversao}");

        }
    }
}
