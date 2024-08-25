namespace Demo
{
    #region Generics[SwapExapmle]
    class Helper
    {
        #region NonGenerics
        //public static void Swap(ref int X, ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        //public static void Swap(ref double X, ref double Y)
        //{
        //    double Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        //public static void Swap(ref Point X, ref Point Y)
        //{
        //    Point Temp = X;
        //    X = Y;
        //    Y = Temp;
        //} 
        #endregion
        #region MyGenerics
        public static void Swap<T>(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }
        #endregion

    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"X={X} , Y={Y}";
        }


    }

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generics[swap example]
            #region NonGenerics
            //int A = 10;
            //int B = 20;
            //Console.WriteLine($"A={A} ,B ={B}");
            //Helper.Swap(ref A,ref B);
            //Console.WriteLine($"A={A},b={B} AFTER SWAPPING");     
            //Console.WriteLine("****************double********");
            //double A0D = 10.50;
            //double B0D = 22.56;
            //Console.WriteLine($"A={A0D} ,B ={B0D}");
            //Helper.Swap(ref A0D, ref B0D);
            //Console.WriteLine($"A={A0D},b={B0D} AFTER SWAPPING");
            //Console.WriteLine("************point*******************");
            //Point P1 = new Point(1, 2);
            //Point P2 = new Point(11, 12);
            //Helper.Swap(ref P1, ref P2);
            //Console.WriteLine($"P1={P1},P2={P2} AFTER SWAPPING"); 
            #endregion
            #region Generics
            int A = 10;
            int B = 20;
            Console.WriteLine($"A={A} ,B ={B}");
            Helper.Swap(ref A, ref B);
            Console.WriteLine($"A={A},b={B} AFTER SWAPPING");
            Console.WriteLine("****************double********");
            double A0D = 10.50;
            double B0D = 22.56;
            Console.WriteLine($"A={A0D} ,B ={B0D}");
            Helper.Swap(ref A0D, ref B0D);
            Console.WriteLine($"A={A0D},b={B0D} AFTER SWAPPING");
            Console.WriteLine("************point*******************");
            Point P1 = new Point(1, 2);
            Point P2 = new Point(11, 12);
            Helper.Swap(ref P1, ref P2);
            Console.WriteLine($"P1={P1},P2={P2} AFTER SWAPPING");
            #endregion
            #endregion
        }
    }
}
