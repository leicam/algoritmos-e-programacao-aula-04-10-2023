namespace ExemplosLacosDeRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("10");

            //Exemplo de laço de repetição while
            //int contador = 10;
            //while (contador  != -1)
            //{
            //    Console.WriteLine("WHILE: " + contador);
            //    //contador = contador - 1;
            //    contador--;
            //}

            //Exemplo de laço de repetição do/while
            //int contadorDois = 10;
            //do
            //{
            //    Console.WriteLine("DO/WHILE: " + contadorDois);
            //    contadorDois--;
            //} while (contadorDois >= 0);

            //Exemplo de laço de repetição for
            //for(int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("FOR: " + i);
            //}

            string opcao = "0";
            do
            {
                try
                {
                    Console.WriteLine("**CALCULADORA**");
                    Console.WriteLine("Selecione uma opção:");
                    Console.WriteLine("1 - Soma");
                    Console.WriteLine("2 - Subtração");
                    Console.WriteLine("3 - Multiplicação");
                    Console.WriteLine("4 - Divisão");
                    Console.WriteLine("0 - Sair");

                    opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            Calculadora.Soma();
                            break;
                        case "2":
                            Calculadora.Subtracao();
                            break;
                        case "3":
                            Calculadora.Multiplicacao();
                            break;
                        case "4":
                            Calculadora.Divisao();
                            break;
                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (opcao != "0");

            Console.WriteLine("Até logo");
        }
    }
}