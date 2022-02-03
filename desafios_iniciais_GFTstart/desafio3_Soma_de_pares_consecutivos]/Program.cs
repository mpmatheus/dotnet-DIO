// Desafio
// O programa deve ler um valor inteiro D indefinidas vezes, 
// ele só irá parar quando o valor de D for igual a 0. Para cada D lido, 
// imprima a soma dos 5 pares consecutivos a partir de D, inclusive ele mesmo , 
// se for par. Se o valor de entrada for 4, por exemplo, a saída deve ser 40, 
// que é o resultado da operação: 4+6+8+10+12, enquanto que se o valor de entrada for 11, 
// por exempo, a saída deve ser 80, que é a soma de 12+14+16+18+20.

// Entrada
// O arquivo de entrada contém muitos valores inteiros. O último valor do arquivo é zero.

// Saída
// Imprima a saida conforme a explicação acima e o exemplo abaixo.
// Exemplo de Entrada
// 4
// 11
// 0
// Exemplo de Saída
// 40
// 80


using System;

namespace DIO
{
    class Program
    {

        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            while (x !=0)
            {
                if (x != 0)
            {
                int resto;
                int total = x ;
                int soma = 0;
                resto = x % 2;
                if(resto == 0)
                {
                    //par
                    for (int i = 0; i < 4; i++)
                    {
                        x = x + 2;
                        total = total + x;
                    }
                    Console.WriteLine(total);
                    x = int.Parse(Console.ReadLine());
                }
                else
                {
                    //impar
                    x++;
                    total++;
                    for (int i = 0; i < 4; i++)
                    {
                        x = x + 2;
                        total = total + x;
                    }
                    Console.WriteLine(total);
                    x = int.Parse(Console.ReadLine());
                }

            }          
            }
            
        }
    }
}