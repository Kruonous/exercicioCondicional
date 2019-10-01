using System;
using System.Globalization;

namespace exercicioCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.");
            Console.WriteLine("Digite um número:");
            double n = double.Parse(Console.ReadLine());

            if(n < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NAO NEGATIVO");
            }

            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar");
            Console.WriteLine("Digite um número: ");
            int x = int.Parse(Console.ReadLine());

            if(x % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }

            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem Sao Multiplos ou Nao sao Multiplos, indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.");
            Console.WriteLine("Digite o valor de A e de B");
            String[] valores = Console.ReadLine().Split(' ');
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);

            if(a % b == 0 || b % a == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não são multiplos");
            }

            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.");
            String[] tempo = Console.ReadLine().Split(' ');
            int inicio = int.Parse(tempo[0]);
            int fim = int.Parse(tempo[1]);
            int duracao;

            if(inicio < fim)
            {
                duracao = fim - inicio;
            }
            else
            {
                duracao = 24 - inicio + fim;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.");
            String[] codigo = Console.ReadLine().Split(' ');
            int item = int.Parse(codigo[0]);
            int quantidade = int.Parse(codigo[1]);

            double total;

            if(item == 1)
            {
                total = quantidade * 4.00;
            }
            else if(item == 2)
            {
                total = quantidade * 4.50;
            }
            else if(item == 3)
            {
                total = quantidade * 5.00;
            }
            else if(item == 4)
            {
                total = quantidade * 2.00;
            }
            else
            {
                total = quantidade * 1.50;
            }
            
            Console.WriteLine("Total R$" + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
