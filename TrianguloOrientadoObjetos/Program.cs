using TrianguloOrientadoObjetos;

internal class Program
{
    public static void Main(string[] args)
    {
        TrianguloObjetos trinagulo = new TrianguloObjetos();
        trinagulo.lado1 = 8;
        trinagulo.lado2= 5;
        trinagulo.lado3 = 6;

        Console.WriteLine(trinagulo.Triangulo());



    }
}