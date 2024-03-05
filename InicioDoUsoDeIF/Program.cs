using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace InicioDoUsoDeIF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aquecimento
            /* Console.Write("Digite o seu salário bruto: R$");
            double bruto = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do seu vale alimentação: R$");
            double alimento = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de filhos que possui: ");
            int filho = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor por filho segundo a sua empresa: R$");
            double valorf = double.Parse(Console.ReadLine());

            Console.Write("Digite Quantas horas extras você teve: ");
            int hora = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor por hora extra segundo a sua empresa: R$");
            double valorh = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do INSS: R$");
            double inss = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do IRPF: R$");
            double ir = double.Parse(Console.ReadLine());

            double liquido = bruto + alimento + (filho * valorf) + (hora * valorh) - inss - ir;

            Console.WriteLine("O valor liquido será de: R$" + liquido.ToString("C");

            Console.ReadKey(); */

            //Calculo de hospedagem
            /* Console.Write("Digite o valor da diario do hotel: R$");
             double valor = double.Parse(Console.ReadLine());

             Console.Write("Digite quantos adultos são: ");
             int adu = int.Parse(Console.ReadLine());

             Console.Write("Digite quantas crianças são: ");
             int cri = int.Parse(Console.ReadLine());

             double familia = adu * valor + cri * (valor / 2);

             Console.WriteLine("O valor por dia da família será de: " + familia.ToString("C"));

             Console.Write("Digite o número de dias de hospedagem: ");
             int dias = int.Parse(Console.ReadLine());

             double total = familia * dias;

             Console.WriteLine("O valor total dera de " +
                 "" + total.ToString("C"));

             Console.Write("Dogite o número de parcelas: "); 
             int par = int.Parse(Console.ReadLine());

             double final = total / par; 

             Console.WriteLine("O valor por parcela sera de R$" + final.ToString("C"));

             Console.ReadKey();*/
            int count = 1;


            while (count == 1)
            {

                Console.Write("Digite a operação que deseja (+,-,*,/): ");
                string op = Console.ReadLine();

                Console.Write("Digite o primeiro número: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                int n2 = int.Parse(Console.ReadLine());

                if (op == "/")
                {
                    double result = n1 / n2;
                    Console.WriteLine("Resultado: " + result);
                    count = 0;
                }
                else if (op == "*")
                {
                    double result = n1 * n2;
                    Console.WriteLine("Resultado: " + result);
                    count = 0;
                }
                else if (op == "+")
                {
                    double result = n1 + n2;
                    Console.WriteLine("Resultado: " + result);
                    count = 0;
                }
                else if (op == "-")
                {


                    double result = n1 - n2;
                    Console.WriteLine("Resultado: " + result);
                    count = 0;

                }
                else
                {
                    Console.WriteLine("Operação inexistente");
                    Console.ReadKey();
                }
            }
            Console.ReadKey();

        }

       
        
    }
}
