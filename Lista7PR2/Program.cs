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
                   Console.Write("Informe a sigla de um estado: ");
        string sigla = Console.ReadLine().ToUpper();
        while (true)

        string nomeEstado;

        switch (sigla)
        {
            case "AC":
                nomeEstado = "Acre";
                break;
            case "AL":
                nomeEstado = "Alagoas";
                break;
            case "AP":
                nomeEstado = "Amapá";
                break;
            case "AM":
                nomeEstado = "Amazonas";
                break;
            case "BA":
                nomeEstado = "Bahia";
                break;
            case "CE":
                nomeEstado = "Ceará";
                break;
            case "DF":
                nomeEstado = "Distrito Federal";
                break;
            case "ES":
                nomeEstado = "Espírito Santo";
                break;
            case "GO":
                nomeEstado = "Goiás";
                break;
            case "MA":
                nomeEstado = "Maranhão";
                break;
            case "MT":
                nomeEstado = "Mato Grosso";
                break;
            case "MS":
                nomeEstado = "Mato Grosso do Sul";
                break;
            case "MG":
                nomeEstado = "Minas Gerais";
                break;
            case "PA":
                nomeEstado = "Pará";
                break;
            case "PB":
                nomeEstado = "Paraíba";
                break;
            case "PR":
                nomeEstado = "Paraná";
                break;
            case "PE":
                nomeEstado = "Pernambuco";
                break;
            case "PI":
                nomeEstado = "Piauí";
                break;
            case "RJ":
                nomeEstado = "Rio de Janeiro";
                break;
            case "RN":
                nomeEstado = "Rio Grande do Norte";
                break;
            case "RS":
                nomeEstado = "Rio Grande do Sul";
                break;
            case "RO":
                nomeEstado = "Rondônia";
                break;
            case "RR":
                nomeEstado = "Roraima";
                break;
            case "SC":
                nomeEstado = "Santa Catarina";
                break;
            case "SP":
                nomeEstado = "São Paulo";
                break;
            case "SE":
                nomeEstado = "Sergipe";
                break;
            case "TO":
                nomeEstado = "Tocantins";
                break;
            default:
                nomeEstado = "Sigla de estado inválida";
                break;
        }

        Console.WriteLine(nomeEstado);
        
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
