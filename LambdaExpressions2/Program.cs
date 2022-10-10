namespace LambdaExpressions2
{
    public delegate string StrDelegate(string s, int x);
    internal class Program
    {
        static void Main(string[] args)
        {
            StrDelegate strDelegate = (string str, int a) => str + Convert.ToString(a);

            Console.WriteLine(strDelegate("abc", 50)) ;

            Console.ReadKey();
        }
    }
}