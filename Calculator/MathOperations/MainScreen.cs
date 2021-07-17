using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.MathOperations
{
    public class MainScreen
    {
        public static void Mainscreen()
        {
            Console.WriteLine("              Digite o numero da operação desejada: ");
            Console.WriteLine("              ================================== ");
            Console.WriteLine("              1 - Adição ");
            Console.WriteLine("              2 - Subtração ");
            Console.WriteLine("              3 - Multiplicação ");
            Console.WriteLine("              4 - Divisão ");
            Console.WriteLine("              5 - Outros ");
            Console.WriteLine("              ================================== ");
            int Opcao = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (Opcao)
            {
                case 1:
                    Addition();
                    break;
                case 2:
                    Subtraction();
                    break;
                case 3:
                    Multiplication();
                    break;
                case 4:
                    Division();
                    break;
                case 5:
                    OtherOperations.SecondMainScreen();
                    break;
                default:
                    Console.WriteLine("Essa opção não existe");
                    break;
            }
        }
        public static void Addition()
        {
            char Resposta;
            double NumeroInicial, SegundoNumero, Total;

            do
            {
                Console.Write("Digite o primeiro numero a ser somado: ");
                NumeroInicial = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo numero a ser somado: ");
                SegundoNumero = double.Parse(Console.ReadLine());

                Total = NumeroInicial + SegundoNumero;
                Console.WriteLine("Total: " + Total);

                Console.Write("Deseja fazer a adição de outros numeros(s/n)? ");
                Resposta = char.Parse(Console.ReadLine());
                Console.Clear();

                switch (Resposta)
                {
                    case 'n':
                        Mainscreen();
                        break;
                }
            } while (Resposta != 'n');
        }

        public static void Subtraction()
        {
            char Resposta;
            double NumeroInicial, SegundoNumero, Total;

            do
            {
                Console.Write("Digite o primeiro numero a ser subtraido: ");
                NumeroInicial = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo numero a ser subtraido: ");
                SegundoNumero = double.Parse(Console.ReadLine());

                Total = NumeroInicial - SegundoNumero;
                Console.WriteLine("Total: " + Total);

                Console.Write("Deseja fazer a subtração de outros numeros(s/n)? ");
                Resposta = char.Parse(Console.ReadLine());
                Console.Clear();

                switch (Resposta)
                {
                    case 'n':
                        Mainscreen();
                        break;
                }
            } while (Resposta != 'n');


        }

        public static void Multiplication()
        {
            char Resposta;
            double NumeroInicial, SegundoNumero, Total;

            do
            {
                Console.Write("Digite o primeiro numero a ser multiplicado: ");
                NumeroInicial = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo numero a ser multiplicado: ");
                SegundoNumero = double.Parse(Console.ReadLine());

                Total = NumeroInicial * SegundoNumero;
                Console.WriteLine("Total: " + Total);

                Console.Write("Deseja fazer a multiplicação de outros numeros(s/n)? ");
                Resposta = char.Parse(Console.ReadLine());
                Console.Clear();

                switch (Resposta)
                {
                    case 'n':
                        Mainscreen();
                        break;
                }
            } while (Resposta != 'n');
        }

        public static void Division()
        {
            char Resposta;
            double NumeroInicial, SegundoNumero, Total;

            do
            {
                Console.Write("Digite o primeiro numero a ser dividido: ");
                NumeroInicial = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo numero a ser dividido: ");
                SegundoNumero = double.Parse(Console.ReadLine());

                Total = NumeroInicial / SegundoNumero;
                Console.WriteLine("Total: " + Total);

                Console.Write("Deseja fazer a divisão de outros numeros(s/n)? ");
                Resposta = char.Parse(Console.ReadLine());
                Console.Clear();

                switch (Resposta)
                {
                    case 'n':
                        Mainscreen();
                        break;
                }
            } while (Resposta != 'n');
        }
    }
}
