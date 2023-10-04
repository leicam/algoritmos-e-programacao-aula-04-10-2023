namespace ExemplosLacosDeRepeticao
{
    /// <summary>
    /// classe estática
    /// </summary>
    public static class Calculadora
    {
        /// <summary>
        /// Solicita dois valores ao usuário e retorna o valor da soma
        /// </summary>
        public static void Soma() 
        {
            Console.WriteLine("Resultado Soma: "
                + (ObterPrimeiroValor() + ObterSegundoValor()));
        }

        /// <summary>
        /// Solicita dois valores ao usuário e retorna o valor da subtração
        /// </summary>
        public static void Subtracao() 
        {
            Console.WriteLine("Resultado Subtração: "
                + (ObterPrimeiroValor() - ObterSegundoValor()));
        }

        /// <summary>
        /// Solicita dois valores ao usuário e retorna o valor da divisão
        /// </summary>
        public static void Divisao() 
        {
            Console.WriteLine("Resultado Divisão: "
                + (ObterPrimeiroValor() / ObterSegundoValor()));
        }

        /// <summary>
        /// Solicita dois valores ao usuário e retorna o valor da multiplicação
        /// </summary>
        public static void Multiplicacao() 
        {
            Console.WriteLine("Resultado Multiplicação: "
                + (ObterPrimeiroValor() * ObterSegundoValor()));
        }

        /// <summary>
        /// Método estático com modificador de acesso privado
        /// </summary>
        /// <returns>decimal</returns>
        private static decimal ObterPrimeiroValor()
        {
            Console.WriteLine("Informe o primeiro valor: ");
            return decimal.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Método estático com modificador de acesso privado
        /// </summary>
        /// <returns>decimal</returns>
        private static decimal ObterSegundoValor()
        {
            Console.WriteLine("Informe o segundo valor: ");
            return decimal.Parse(Console.ReadLine());
        }
    }
}
