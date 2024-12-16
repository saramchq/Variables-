namespace variaveis1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Olá, utilizador! Escreva um número qualquer");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numero + 5);

            int numA, numB;
            Console.WriteLine("Olá usuário! Digite um número qualquer");
            numA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor digite mais um número!");
            numB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A soma de {0} com {1} é igual a {2}", numA, numB, (numA + numB));
            Console.ReadKey();
        }
    }
}   