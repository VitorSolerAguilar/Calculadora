using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Calculator.MathOperations
{
    public class OtherOperations
    {
        public static void SecondMainScreen()
        {
            Console.WriteLine("              Digite o numero da operação desejada: ");
            Console.WriteLine("              ================================== ");
            Console.WriteLine("              1 - Raiz Quadrada ");
            Console.WriteLine("              2 - Valor de PI ");
            Console.WriteLine("              3 - Potenciação ");
            Console.WriteLine("              4 - Voltar  ");
            Console.WriteLine("              ================================== ");
            int Opcao = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (Opcao)
            {
                case 1:
                    SquareRoot();
                    break;
                case 2:
                    PiValue();
                    break;
                case 3:
                    Potentiation();
                    break;
                case 4:
                    MainScreen.Mainscreen();
                    break;
                default:
                    Console.WriteLine("Essa opção não existe");
                    break;
            }
        }
        public static void SquareRoot()
        {
            char Resposta;
            double NumeroInicial, Total;

            do
            {
                Console.Write("Digite o numero a ser calculado a raiz: ");
                NumeroInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Total = Math.Sqrt(NumeroInicial);
                Console.WriteLine(Total.ToString("F2", CultureInfo.InvariantCulture));

                Console.Write("Deseja calcular a raiz de outro numero(s/n)? ");
                Resposta = char.Parse(Console.ReadLine());
                Console.Clear();

                switch (Resposta)
                {
                    case 'n':
                        OtherOperations.SecondMainScreen();
                        break;
                }
            } while (Resposta != 'n');
        }

        public static void PiValue()
        {
            char Resposta;

            Console.WriteLine("3.14159265");
            Console.Write("Deseja voltar ao menu principal(s/n)? ");
            Resposta = char.Parse(Console.ReadLine());
            Console.Clear();
            if (Resposta == 's' || Resposta == 'S')
            {
                MainScreen.Mainscreen();
            }
            else
            {
                SecondMainScreen();
            }
        }

        public static void Potentiation()
        {
            char Resposta;
            double Base, Expoente, Total;

            do
            {
                Console.Write("Digite o numero para ser a base: ");
                Base = double.Parse(Console.ReadLine());

                Console.Write("Digite o numero para ser o expoente: ");
                Expoente = double.Parse(Console.ReadLine());

                Total = Math.Pow(Base, Expoente);
                Console.WriteLine("Potência = " + Total);

                Console.Write("Deseja fazer a potencia de outros numeros(s/n)? ");
                Resposta = char.Parse(Console.ReadLine());
                Console.Clear();

                switch (Resposta)
                {
                    case 'n':
                        OtherOperations.SecondMainScreen();
                        break;
                }
            } while (Resposta != 'n');
        }
    }
}