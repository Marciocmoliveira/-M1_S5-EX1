using System;

class Program
{

    //Resposta Exercício 01, semana 5, Prof. Jaime
    static void Main(string[] args)
    {
        double num1 = 0;
        double num2 = 0;

        try
        {
            Console.Write("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            if (num2 == 0)
            {
                throw new DivideByZeroException();
            }

            double resultado = num1 / num2;
            Console.WriteLine("O resultado da divisão é: " + resultado);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Erro: Não é possível dividir por zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Letras não podem ser informadas.");
        }
        catch (Exception)
        {
            Console.WriteLine("Erro: Ocorreu um erro inesperado.");
        }
        finally
        {
            num1 = 0;
            num2 = 0;
        }
    }
}

