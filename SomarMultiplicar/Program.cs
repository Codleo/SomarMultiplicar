public class Program
{
    public static void Main()
    {
        int numero1 = 10;
        int numero2 = 5;

        var resultado = SomarEMultiplicar(numero1, numero2);

        Console.WriteLine($"Soma: {resultado.Item1}");
        Console.WriteLine($"Multiplicação: {resultado.Item2}");
    }


    public static (int, int) SomarEMultiplicar(int a, int b)
    {
        int soma = a + b;
        int multiplicacao = a * b;

        return (soma, multiplicacao);
    }
}
