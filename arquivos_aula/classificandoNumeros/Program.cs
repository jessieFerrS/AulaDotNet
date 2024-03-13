namespace classificandoNumeros;

class Program
{
    static void Main(string[] args)
    {
        List<int>pares = new List<int>();
        List<int>impares = new List<int>();
        for (int i = 0; i <= 100; i++)
        {
            if(i % 2 == 0)
            {
                pares.Add(i);
                //Console.WriteLine($"{i} - Par");
            }
            else{
                impares.Add(i);
                //Console.WriteLine($"{i} - Impar");
            }
        }
        Console.WriteLine("Valores Pares: " + string.Join(" , ", pares));
        Console.WriteLine("Valores Impares: " + string.Join(" , ", impares));
    }
}
