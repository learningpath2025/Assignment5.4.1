namespace Assignment5._4._1
{
    internal class Program
    {

        //With Recursion
        public static void PrintIndividualNumber2(int n)
        {
            if (n == 0) return;
            PrintIndividualNumber2(n / 10);
            Console.Write($"{n % 10} ");
        }

        //With Recursion Alternative
        public static void PrintIndividualNumber1(int n)
        {
            string s = n.ToString();
            int l = s.Length;

            while (l > 0) 
            {
                int d = GetDivisor(l - 1);
                Console.Write($"{n/d} ");
                n %= d;
                l--;
            }
        }

        public static int GetDivisor(int l)
        {
            string s = "1";
            while (l > 0)
            {
                s += Zero();
                l--;
            }
            return Convert.ToInt32(s);
        }

        public static string Zero() { return "0"; }

        //Without Recursion
        public static void PrintIndividualNumber(int n)
        {
            string x = n.ToString();
            List<int> digits = x.Select(c => int.Parse(c.ToString())).ToList();
            Console.Write(string.Join(" ", digits));
        }
        static void Main(string[] args)
        {
            int n = 1234565879;
            PrintIndividualNumber2(n);
        }
    }
}
