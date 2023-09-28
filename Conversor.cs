using System;

class Program
{
    static void Main(string[] args)
    {
        while (true) // codigo em loop infinito 
        {
            Console.Write("Digite um número decimal (ou 's' para sair): ");//entrada 
            string input = Console.ReadLine();

            if (input.ToLower() == "s")
            {
                break; // Sai do loop se o for digitado 's'
            }

            if (int.TryParse(input, out int decimalNumber))
            {
                string binary = DecimalToBinary(decimalNumber);
                Console.WriteLine($"O número binário correspondente é: {binary}");//saida
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número decimal válido ou 's' para sair.");
            }
        }
    }

    static string DecimalToBinary(int decimalNumber)
    {
        if (decimalNumber == 0)
            return "0";

        string binary = "";
        int quotient = decimalNumber;

        while (quotient > 0)
        {
            int remainder = quotient % 2;
            binary = remainder.ToString() + binary;
            quotient /= 2;
        }

        return binary;
    }
}

