// fiz em C# porque já não tenho o dev cpp no computador e no visual studio só tenho C#.
internal class Program
{
    private static void Main(string[] args)
    {
        double nota1, nota2, nota3, nota4, media;

        Console.WriteLine("Insira primeira nota: ");
        nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insira segunda nota: ");
        nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insira terceira nota: ");
        nota3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insira quarta nota: ");
        nota4 = Convert.ToDouble(Console.ReadLine());

        media = ((nota1*0.5) + (nota2*0.1) + (nota3*0.1) + (nota4*0.3)) / 4;

        Console.WriteLine("As notas são: ");
        Console.WriteLine(nota1);
        Console.WriteLine(nota2);
        Console.WriteLine(nota3);
        Console.WriteLine(nota4);

        Console.WriteLine("A média é: ");
        Console.WriteLine(media);

        Console.ReadKey();
    }
}