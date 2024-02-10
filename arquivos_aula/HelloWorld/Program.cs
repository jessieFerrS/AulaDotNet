namespace HelloWorld; //nome do projeto

class Program 
{
    static void Main(string[] args)
    {
        int n1 = 1;
        int n2 = 1;
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        
        for (int i=2; i <= 10; i++){
            int res = n1 + n2;
            Console.WriteLine(res);
            n1 = n2;
            n2 = res;
        }
    }
}
