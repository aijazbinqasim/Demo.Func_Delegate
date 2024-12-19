namespace Demo.Func_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Func<int, int, int> add = ClassA.Sum;
            var result = add(200, 400);
            Console.WriteLine(result);

            Func<string, string, string> concat = ClassA.Concat;
            var result1 = concat.Invoke("Aijaz", "Abro");
            Console.WriteLine(result1);


            //Func<int, int> Square = number => number * number;
            //Console.WriteLine(Square.Invoke(4));

            Func<int, int> Square = delegate(int x) 
            { 
                return x * x;
            };

           Console.Write(Square(6));
        }
    }

    public class ClassA
    {
        public static int Sum(int v1, int v2) => v1 + v2;

        public static string Concat(string s1, string s2) => $"{s1} - {s2}";
    }
}
