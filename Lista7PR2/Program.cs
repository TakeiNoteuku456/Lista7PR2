using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int Ex;

            Console.WriteLine("========Menu========");
            Console.WriteLine("====Exercício 1=====");
            Console.WriteLine("====Exercício 2=====");
            Console.WriteLine("====Exercício 3=====");
            Console.WriteLine("====Exercício 4=====");
            Console.WriteLine("====Exercício 5=====");
            Console.WriteLine("====Exercício 6=====");
            Console.WriteLine("====Exercício 7=====");

            Ex = int.Parse(Console.ReadLine());

            switch (Ex)
            {
                case 1:
                    int totalItens = 0, repet = 2;
                    double totalCompra = 0;

                    while ( repet != 1)//laço infinito
                    {
                        Console.Write("Informe a quantidade de itens: ");
                        int quantidade = int.Parse(Console.ReadLine());

                        if (quantidade <= 0)
                        {
                            Console.WriteLine($"Total de itens: R$",totalItens);
                            Console.WriteLine($"Total da compra: R$",totalCompra);
                            break;
                        }

                        Console.Write("Informe o preço do produto: R$");
                        double preco = double.Parse(Console.ReadLine());

                        totalItens += quantidade;
                        totalCompra += quantidade * preco;
                    }
                    break;
                case 2:
                    string nomedoproduto;
                    int Numerodeitens = 0, parada = 2;
                    double Preçodoproduto, menorValor, maiorvalor;

                    menorValor = float.MaxValue;
                    maiorvalor = float.MinValue;

                    Console.WriteLine("=== Controle de Estoque da Mercearia Bom Preço ===\n");

                    while ( parada != 1)//laço infinito
                        Console.Write("Informe o nome do produto (ou digite 0 para encerrar): ");
                    nomedoproduto = Console.ReadLine();

                    Console.Write("Informe a quantidade de intens (ou digite 0 para encerrar): ");
                    Numerodeitens = int.Parse(Console.ReadLine());

                    Console.Write("Informe a quantidade de intens (ou digite 0 para encerrar): ");
                    Preçodoproduto = int.Parse(Console.ReadLine());

                    double total = Numerodeitens * Preçodoproduto;
                    if (total < Preçodoproduto)
                    {
                        Console.WriteLine("\nCadastro de produtos encerrado.");
                        break;

                    }
                    break;
                case 3:
                    Console.Write("Digite o número de avaliações planejadas: ");
                    int numAvaliacoes = int.Parse(Console.ReadLine());
                    int i = 1;
                    double somaPesos = 0;
                    while(true)
                    for (i = 1; i <= numAvaliacoes; i++);
                    {
                        Console.Write($"Digite o peso da avaliação {i}: ");
                        double Peso = double.Parse(Console.ReadLine());
                        somaPesos += Peso;
                    }

                    if (somaPesos < 100)
                    {
                        Console.WriteLine("A soma dos pesos é insuficiente R$", somaPesos, ".");
                    }
                    else if (somaPesos > 100)
                    {
                        Console.WriteLine("A soma dos pesos é excedente R$", somaPesos, ".");
                    }
                    else
                    {
                        Console.WriteLine("A soma dos pesos é adequada R$", somaPesos, ".");
                    }
                    break;
                case 4:
                    int Laço = 1;
                    while (Laço != 0)
                    {
                        Console.Write("Digite o número do dia (1 a 31): ");
                        int dia = int.Parse(Console.ReadLine());
                        Console.Write("Digite o número do mês (1 a 12): ");
                        int mes = int.Parse(Console.ReadLine());

                        while (true)
                        {
                            if (mes < 1 || mes > 12)
                            {
                                Console.WriteLine("Mês inválido!");
                                return;
                            }

                            string estacao = "";
                            if (mes == 12 || mes <= 2)
                            {
                                estacao = "Verão";
                            }
                            else if (mes >= 3 && mes <= 5)
                            {
                                estacao = "Outono";
                            }
                            else if (mes >= 6 && mes <= 8)
                            {
                                estacao = "Inverno";
                            }
                            else // mes >= 9 && mes <= 11
                            {
                                estacao = "Primavera";
                            }

                            if ((mes == 3 && dia >= 20) || mes == 4 || mes == 5 && dia <= 20)
                            {
                                Console.WriteLine("O mês ", mes, " de 2023 é de transição entre Outono e Inverno.");
                            }
                            else if ((mes == 6 && dia >= 21) || mes == 7 || mes == 8 && dia <= 22)
                            {
                                Console.WriteLine("O mês ", mes, " de 2023 é de transição entre Inverno e Primavera.");
                            }
                            else if ((mes == 9 && dia >= 23) || mes == 10 || mes == 11 && dia <= 20)
                            {
                                Console.WriteLine("O mês ", mes, " de 2023 é de transição entre Primavera e Verão.");
                            }
                            else if ((mes == 12 && dia >= 21) || mes == 1 || mes == 2 && dia <= 18)
                            {
                                Console.WriteLine("O mês ", mes, " de 2023 é de transição entre Verão e Outono.");
                            }
                            else
                            {
                                Console.WriteLine("O mês ", mes, " de 2023 é de ", estacao, ".");
                            }
                        }
                    }
                    break;
                case 5:
                    int Laço1 = 1;
                    while (Laço1 != 0)
                    {
                        Console.Write("Digite um número inteiro entre 1 e 12: ");
                        int Mes = int.Parse(Console.ReadLine());

                        switch (Mes)
                        {
                            case 1:
                            case 2:
                            case 12:
                                Console.WriteLine("Estação do ano: Verão");
                                break;
                            case 3:
                            case 4:
                            case 5:
                                Console.WriteLine("Estação do ano: Outono");
                                break;
                            case 6:
                            case 7:
                            case 8:
                                Console.WriteLine("Estação do ano: Inverno");
                                break;
                            case 9:
                            case 10:
                            case 11:
                                Console.WriteLine("Estação do ano: Primavera");
                                break;
                            default:
                                Console.WriteLine("Mês inválido");
                                break;
                        }
                        Console.ReadLine();
                    }
                    break;
                case 6:
                    int Laço2 = 1;
                    while (Laço2 != 0)
                    {
                        Console.Write("Digite o seu peso em kg: ");
                        double peso = double.Parse(Console.ReadLine());

                        Console.Write("Digite a sua altura em metros: ");
                        double altura = double.Parse(Console.ReadLine());

                        double imc = peso / (altura * altura);

                        Console.Write("Seu IMC é: " + imc);

                        if (imc < 18.5)
                        {
                            Console.WriteLine("\nVocê está abaixo do peso.");
                        }
                        else if (imc >= 18.5 && imc <= 24.9)
                        {
                            Console.WriteLine("\nSeu peso está normal.");
                        }
                        else if (imc >= 25.0 && imc <= 29.9)
                        {
                            Console.WriteLine("\nVocê está com sobrepeso.");
                        }
                        else if (imc >= 30.0 && imc <= 34.9)
                        {
                            Console.WriteLine("\nVocê está com obesidade grau I.");
                        }
                        else if (imc >= 35.0 && imc <= 39.9)
                        {
                            Console.WriteLine("\nVocê está com obesidade grau II.");
                        }
                        else
                        {
                            Console.WriteLine("\nVocê está com obesidade grau III (mórbida).");
                        }
                    }
                    break;
                case 7:
                    int Laço3 = 1;
                    while (Laço3 != 0)
                    {
                        Console.Write("Digite um número inteiro positivo: ");
                        int numero = int.Parse(Console.ReadLine());

                        if (numero <= 0)
                        {
                        Console.WriteLine("O número deve ser maior que zero.");
                        }
                        else
                        {
                        Console.WriteLine("Os divisores de " , numero , " são:");
                        for (int i = 1; i <= numero; i++)
                        {
                        if (numero % i == 0)
                        {
                        Console.WriteLine(i);
                        }
                        }
                        }
                    }
                default:
                    Console.WriteLine("INVALIDO");
                    break;

            }
        }
    }
}
