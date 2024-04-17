// See https://aka.ms/new-console-template for more information
inicio:
Console.WriteLine("Exercícios propostos - While loop");
Console.Write("Qual exercício você quer visualizar ? (1, 2, 3) : ");
if (int.TryParse(Console.ReadLine(), out int exercicio) && exercicio >= 1 && exercicio <= 3)
{
    switch (exercicio)
    {
        case 1:
            Exercicio1();
            break;
        case 2:
            Exercicio2();
            break;
        default:
            Exercicio3();
            break;
    }
}
else
{
    Console.WriteLine("\nEscreva um número válido");
    Console.WriteLine("========================\n");
    goto inicio;
}
goto inicio;
static void Exercicio1()
{
    string senha;
    Console.Clear();
    Console.WriteLine("Exercício 1: Senha"); //senha = 2004
    Console.WriteLine("==================\n");
    Console.Write("Digite a senha: ");
    senha = Console.ReadLine();
    while (senha != "2004")
    {
        Console.WriteLine("\nSenha inválida");
        Console.WriteLine("==============\n");
        Console.Write("Digite a senha: ");
        senha = Console.ReadLine();
    }
    Console.WriteLine("\n==========================");
    Console.WriteLine("\nSenha validada com sucesso");
    Console.WriteLine("\n==========================");
    Console.Write("\nPressione a tecla 'Enter' para retornar: ");
    Console.ReadLine();
    Console.Clear();
}
static void Exercicio2()
{
start:
    Console.Clear();

    int[] coordenadas = new int[2];
    coordenadas[0] = 1;
    coordenadas[1] = 1;
    while (coordenadas[0] != 0 && coordenadas[1] != 0)
    {
        Console.WriteLine("Exercicio 2: Plano Cartesiano");
        Console.WriteLine("=============================\n");
        Console.WriteLine("Escreva 0 em qualquer uma das coordenadas para retornar ao inicio");
        Console.Write("Digite as coordenadas X e Y: ");
        string[] xy = Console.ReadLine().Split(" ");

        try
        {
            if (xy[2] != null)
            {
                Console.WriteLine("\n=========================================");
                Console.WriteLine("\nEscreva uma coordenada com duas dimensões\n");
                Console.WriteLine("=========================================\n");
                Console.Write("\nPressione 'enter' para retornar ao inicio: ");
                Console.ReadLine();
                goto start;
            }
        }
        catch
        {
            if (!int.TryParse(xy[0], out coordenadas[0]))
            {
                Console.WriteLine("\n===================");
                Console.WriteLine("\nCoordenada invalida\n");
                Console.WriteLine("===================\n");
                Console.Write("\nPressione 'enter' para retornar ao inicio: ");
                Console.ReadLine();
                goto start;
            }
            else if (!int.TryParse(xy[1], out coordenadas[1]))
            {
                Console.WriteLine("\n===================");
                Console.WriteLine("\nCoordenada invalida\n");
                Console.WriteLine("===================\n");
                Console.Write("\nPressione 'enter' para retornar ao inicio: ");
                Console.ReadLine();
                goto start;
            }
        }
        if (coordenadas[0] >= 1 && coordenadas[1] >= 1)
        {
            Console.WriteLine("\n==============================================================");
            Console.WriteLine("\nAs coordenadas estão no primeiro quadrante do plano cartesiano\n");
            Console.WriteLine("==============================================================\n");
            Console.Write("\nPressione 'enter' para retornar ao inicio: ");
            Console.ReadLine();
            Console.Clear();
        }
        else if (coordenadas[0] <= -1 && coordenadas[1] <= -1)
        {
            Console.WriteLine("\n==============================================================");
            Console.WriteLine("\nAs coordenadas estão no terceiro quadrante do plano cartesiano\n");
            Console.WriteLine("==============================================================\n");
            Console.Write("\nPressione 'enter' para retornar ao inicio: ");
            Console.ReadLine();
            Console.Clear();
        }
        else if (coordenadas[0] <= -1 && coordenadas[1] != 0)
        {
            Console.WriteLine("\n=============================================================");
            Console.WriteLine("\nAs coordenadas estão no segundo quadrante do plano cartesiano\n");
            Console.WriteLine("=============================================================\n");
            Console.Write("\nPressione 'enter' para retornar ao inicio: ");
            Console.ReadLine();
            Console.Clear();
        }
        else if (coordenadas[1] <= -1 && coordenadas[0] != 0)
        {
            Console.WriteLine("\n============================================================");
            Console.WriteLine("\nAs coordenadas estão no quarto quadrante do plano cartesiano\n");
            Console.WriteLine("============================================================\n");
            Console.Write("\nPressione 'enter' para retornar ao inicio: ");
            Console.ReadLine();
            Console.Clear();
        }
    }
    Console.Clear();
}

static void Exercicio3()
{
    int numero = 0;
    int gasolina = 0, diesel = 0, alcool = 0;
    int total;
    while (numero != 4)
    {
        Console.Clear();
        total = gasolina + diesel + alcool;
        Console.WriteLine("Exercício 3: Posto");
        Console.WriteLine("==================\n");
        Console.WriteLine("Número de registros: " + total);
        Console.Write("Digite o tipo de combustivel comprado (1 para gasolina, 2 para diesel, 3 para alcool, 4 para finalizar): ");
        if (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Insira um número válido");
        }
        else
        {
            switch (numero)
            {
                case 1:
                    gasolina++;
                    break;
                case 2:
                    diesel++;
                    break;
                case 3:
                    alcool++;
                    break;
                case 4:
                    Console.WriteLine("\nValores finais");
                    Console.WriteLine("\n=======================\n");
                    Console.WriteLine("Gasolina: " + gasolina);
                    Console.WriteLine("Diesel: " + diesel);
                    Console.WriteLine("Alcool: " + alcool);
                    Console.WriteLine("\n=======================\n\n");
                    Console.Write("Digite a tecla 'enter' para continuar: ");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("\n=======================\n");
                    Console.WriteLine("\nInsira um número válido\n");
                    Console.WriteLine("\n=======================\n\n");
                    Console.Write("Digite a tecla 'enter' para continuar: ");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
