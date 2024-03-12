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



            /*if operação
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
            Console.ReadKey(); */

            /*imc tabela
            Console.Write("Digite a sua altura(m): ");
            double m = double.Parse(Console.ReadLine());

            Console.Write("Digite o deu peso: ");
            int p = int.Parse(Console.ReadLine());

            double imc = p / (m * m);

           if (imc <= 16.9) 
            { 
                Console.WriteLine("Você está muito abaixo do peso, " + imc);
              
            }
           else if (imc <= 18.4)
            {
                Console.WriteLine("Você está abaixo do peso, " + imc);

            }
           else if (imc <= 24.9)
            {
                Console.WriteLine("Você está no peso normal, " + imc);

            }
            else if (imc <= 29.9)
            {
                Console.WriteLine("Você está acima do peso, " + imc);

            }
            else if (imc <= 34.9)
            {
                Console.WriteLine("Você está com obesidade grau I, " + imc);

            }
           else if (imc <= 40)
            {
                Console.WriteLine("Você está com obesidade grau II, " + imc);

            }
           else if (imc >= 40)
            {
                Console.WriteLine("Você está com obesidade grau III, " + imc);
                Console.WriteLine("███████████████████████████\r\n███████▀▀▀░░░░░░░▀▀▀███████\r\n████▀░░░░░░░░░░░░░░░░░▀████\r\n███│░░░░░░░░░░░░░░░░░░░│███\r\n██▌│░░░░░░░░░░░░░░░░░░░│▐██\r\n██░└┐░░░░░░░░░░░░░░░░░┌┘░██\r\n██░░└┐░░░░░░░░░░░░░░░┌┘░░██\r\n██░░┌┘▄▄▄▄▄░░░░░▄▄▄▄▄└┐░░██\r\n██▌░│██████▌░░░▐██████│░▐██\r\n███░│▐███▀▀░░▄░░▀▀███▌│░███\r\n██▀─┘░░░░░░░▐█▌░░░░░░░└─▀██\r\n██▄░░░▄▄▄▓░░▀█▀░░▓▄▄▄░░░▄██\r\n████▄─┘██▌░░░░░░░▐██└─▄████\r\n█████░░▐█─┬┬┬┬┬┬┬─█▌░░█████\r\n████▌░░░▀┬┼┼┼┼┼┼┼┬▀░░░▐████\r\n█████▄░░░└┴┴┴┴┴┴┴┘░░░▄█████\r\n███████▄░░░░░░░░░░░▄███████\r\n██████████▄▄▄▄▄▄▄██████████\r\n███████████████████████████");

            }
          
         

            Console.ReadKey();  
            */


            Console.Write("Digite a sua media da nota: ");
            int nota =int.Parse( Console.ReadLine());

            Console.Write("Digite a porcentagem de presença: ");
            int pre = int.Parse(Console.ReadLine());

            if (nota >= 7 && pre >= 75)
            {
                Console.WriteLine("Você foi aprovado");
            }
            else if (nota >=4 && pre >= 75 || nota >= 7 && pre < 75)
            {
                Console.WriteLine("Você ficou de recuperação");
            }
            else
            {
                Console.WriteLine("███████████████████████████\r\n███████▀▀▀░░░░░░░▀▀▀███████\r\n████▀░░░░░░░░░░░░░░░░░▀████\r\n███│░░░░░░░░░░░░░░░░░░░│███\r\n██▌│░░░░░░░░░░░░░░░░░░░│▐██\r\n██░└┐░░░░░░░░░░░░░░░░░┌┘░██\r\n██░░└┐░░░░░░░░░░░░░░░┌┘░░██\r\n██░░┌┘▄▄▄▄▄░░░░░▄▄▄▄▄└┐░░██\r\n██▌░│██████▌░░░▐██████│░▐██\r\n███░│▐███▀▀░░▄░░▀▀███▌│░███\r\n██▀─┘░░░░░░░▐█▌░░░░░░░└─▀██\r\n██▄░░░▄▄▄▓░░▀█▀░░▓▄▄▄░░░▄██\r\n████▄─┘██▌░░░░░░░▐██└─▄████\r\n█████░░▐█─┬┬┬┬┬┬┬─█▌░░█████\r\n████▌░░░▀┬┼┼┼┼┼┼┼┬▀░░░▐████\r\n█████▄░░░└┴┴┴┴┴┴┴┘░░░▄█████\r\n███████▄░░░░░░░░░░░▄███████\r\n██████████▄▄▄▄▄▄▄██████████\r\n███████████████████████████");
                Console.WriteLine("Que Burro kkk repetiu");
            }

            Console.ReadKey();
        }

       
        
    }
}
