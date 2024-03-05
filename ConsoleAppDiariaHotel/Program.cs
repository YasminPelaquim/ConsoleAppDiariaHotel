using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDiariaHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor da diária: ");
            int diaria = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade de adultos: ");
            int adult = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade de crianças: ");
            int cri = int.Parse(Console.ReadLine());

            double valordia = (diaria * adult) + ((diaria/2) * cri);

            Console.WriteLine("O valor da diária para a família é de " + valordia.ToString("C"));

            Console.WriteLine("Número de dias de hospedagem: ");
            int dias = int.Parse(Console.ReadLine());

            double valtotal = valordia * dias;

            Console.WriteLine("O valor total da hospedagem é de " + valtotal.ToString("C"));

            Console.WriteLine("Número de parcelas: ");
            int par = int.Parse(Console.ReadLine());

            double valpar = valtotal / par;

            Console.WriteLine("O valor de cada parcela é de " + valpar.ToString("C"));

            Console.ReadKey();
        }
    }
}
