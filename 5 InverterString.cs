using System;

/* 
class Program
{
    static void Main()
    {
        string input = "Teste Logica";

        string invertida = InverterString(input);

        Console.WriteLine($"String normal: {input}");
        Console.WriteLine($"String invertida: {invertida}");
    }

    static string InverterString(string texto)
    {
        char[] caracteres = texto.ToCharArray();

        int inicio = 0;
        int fim = caracteres.Length - 1;

        while (inicio < fim)
        {
            char temp = caracteres[inicio];
            caracteres[inicio] = caracteres[fim];
            caracteres[fim] = temp;
            inicio++;
            fim--;
        }

        return new string(caracteres);
    }
}

*/


//5) Escreva um programa que inverta os caracteres de um string.

//IMPORTANTE:
//a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
//b) Evite usar funções prontas, como, por exemplo, reverse; 
