using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Exercício 2
            //int num;

            //Console.WriteLine("Digite um número");
            //num = int.Parse(Console.ReadLine());

            //if (num % 3 == 0 && num % 5 == 0)
            //{
            //    Console.WriteLine("O número é divisível ambos 3 e 5.");
            //}

            //else if (num % 4 == 0 && num % 7 == 0)
            //{
            //    Console.WriteLine("O número é divisível ambos 4 e 7.");
            //}

            //else
            //{
            //    Console.WriteLine("O número não é divisível por 3 nem por 5.");
            //    Console.WriteLine("O número não é divisível por 4 nem por 7.");
            //};


            //----------------------------------------------------------


            // Exercício 3
            //int num1, num2, num3;

            //Console.WriteLine("Digite um número");
            //num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o segundo número");
            //num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o terceiro número");
            //num3 = int.Parse(Console.ReadLine());

            //if (num1 < num2 && num1 < num3)
            //{
            //    if (num2 < num3)
            //    {
            //        Console.WriteLine("{0}", num3);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0}", num2);
            //    }
            //}
            //else if (num2 < num1 && num2 < num3)
            //{
            //    if (num1 < num3)
            //    {
            //        Console.WriteLine("{0}", num3);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0}", num1);
            //    }
            //}
            //else
            //{
            //    if (num1 < num2)
            //    {
            //        Console.WriteLine("{0}", num2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0}", num1);
            //    }
            //}


            //----------------------------------------------------------



            // Exercício 4
            //int dia;

            //Console.WriteLine("Digite o dia da semana");
            //dia = int.Parse(Console.ReadLine());

            //if (dia == 1)
            //{
            //    Console.WriteLine("Domingo:");
            //    Console.WriteLine("Não tem aula, só ficar jogando o dia inteiro");
            //}

            //if (dia == 2)
            //{
            //    Console.WriteLine("Segunda-Feira:");
            //    Console.WriteLine("1 - 2: Filosofia");
            //    Console.WriteLine("3 - 4: Português");
            //    Console.WriteLine("5 - 6: Matemática");
            //}

            //else if (dia == 3)
            //{
            //    Console.WriteLine("Terça-Feira:");
            //    Console.WriteLine("1 - 2: Química");
            //    Console.WriteLine("3 - 4: História");
            //    Console.WriteLine("5 - 6: Inglês para o mundo da informática");
            //}

            //else if (dia == 4)
            //{
            //    Console.WriteLine("Quarta-Feira:");
            //    Console.WriteLine("1 - 2: Biologia");
            //    Console.WriteLine("3: Português");
            //    Console.WriteLine("4 - 6: Programação 2");
            //}

            //else if (dia == 5)
            //{
            //    Console.WriteLine("Quinta-Feira:");
            //    Console.WriteLine("1 - 2: Física");
            //    Console.WriteLine("3 - 4: Redes de Computadores");
            //    Console.WriteLine("5 - 6: Sociologia");
            //}

            //else if (dia == 6)
            //{
            //    Console.WriteLine("Sexta-Feira:");
            //    Console.WriteLine("1 - 2: Geoografia");
            //    Console.WriteLine("3: Matemática");
            //    Console.WriteLine("4 - 6: Banco De Dados");
            //}

            //else if (dia == 7)
            //{
            //    Console.WriteLine("Sábado:");
            //    Console.WriteLine("Depende se o dia tiver sábado letivo. Mas se não tiver, é só ficar jogando e depois fazer o curso");
            //}

            //else
            //{
            //    Console.WriteLine("Dia da semana não identificado");
            //}


            //----------------------------------------------------------



            // Exercício 5
            //int num, numbackup = 0, minValor = 0, maxValor = 0;

            //Console.WriteLine("Qual o número?");
            //num = int.Parse(Console.ReadLine());

            //for (; num != 0;)
            //{
            //    Console.WriteLine("Qual o número?");
            //    num = int.Parse(Console.ReadLine());

            //    int total = num;

            //    if (num == 0)
            //    {
            //        Console.WriteLine("Maior quantia {0}", maxValor);
            //        Console.WriteLine("Menor quantia {0}", numbackup);
            //        break;
            //    }

            //    else
            //    {
            //        if (total > maxValor)
            //        {
            //            maxValor = total;
            //        }

            //        if (total < minValor)
            //        {
            //            minValor = total;
            //        }

            //    }

            //    numbackup = minValor;
            //}


            //----------------------------------------------------------


            //Exercício 7
            //int vez = 0, num, med, numbackup = 0, minValor = 0, maxValor = 0;

            //Console.WriteLine("Qual o número?");
            //num = int.Parse(Console.ReadLine());

            //for (; num != 0;)
            //{
            //    vez + 1;
            //    Console.WriteLine("Qual o número?");
            //    num = int.Parse(Console.ReadLine());

            //    int total = num;

            //    if (num == 0)
            //    {
            //        media = total / vez;
            //        Console.WriteLine("Maior quantia {0}", maxValor);
            //        Console.WriteLine("Menor quantia {0}", numbackup);
            //        Console.WriteLine("Média é {0}", media);
            //        break;
            //    }

            //    else
            //    {
            //        if (total > maxValor)
            //        {
            //            maxValor = total;
            //        }

            //        if (total < minValor)
            //        {
            //            minValor = total;
            //        }

            //    }

            //    numbackup = minValor;
            //}

        }
    }
    }

