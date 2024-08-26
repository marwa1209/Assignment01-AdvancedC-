namespace Demo
{
    #region Generics[SwapExapmle &Search Example]
    class Helper<T>
    {
        #region NonGenerics
        #region SwapExapmle
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
        #region [Search Example]
        //public static int SearchArray(int[] array , int value)
        //{
        //    if(array is not null)
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            if (value == array[i])
        //            {
        //                return i;
        //            }
        //        }
        //    }
        //    return -1;
        //}
        //public static int SearchArray(string[] array, string value)
        //{
        //    if (array is not null)
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            if (value == array[i])
        //            {
        //                return i;
        //            }
        //        }
        //    }
        //    return -1;
        //}
        #endregion
        #endregion
        #region MyGenerics
        #region SwapExample
        public static void Swap<T>(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }
        #endregion

        #region SearchExanple
        public static int SearchArray(T[] array, T value)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (value.Equals(array[i]))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        #endregion
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

    class Employe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public override bool Equals(object? obj)
        {
            Employe employe = obj as Employe;
            return (this.Id==employe.Id)&&(this.Name==employe.Name)&&(this.Salary==employe.Salary);
        }
        public override int GetHashCode()
        {
            //return this.Id.GetHashCode() + this.Name.GetHashCode()+this.Salary.GetHashCode();
            return HashCode.Combine(this.Id.GetHashCode(), this.Name.GetHashCode(),this.Salary.GetHashCode());
        }
    }
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
            Helper<int>.Swap(ref A, ref B);
            Console.WriteLine($"A={A},b={B} AFTER SWAPPING");
            Console.WriteLine("****************double********");
            double A0D = 10.50;
            double B0D = 22.56;
            Console.WriteLine($"A={A0D} ,B ={B0D}");
            Helper<double>.Swap(ref A0D, ref B0D);
            Console.WriteLine($"A={A0D},b={B0D} AFTER SWAPPING");
            Console.WriteLine("************point*******************");
            Point P1 = new Point(1, 2);
            Point P2 = new Point(11, 12);
            Helper<Point>.Swap(ref P1, ref P2);
            Console.WriteLine($"P1={P1},P2={P2} AFTER SWAPPING");
            #endregion
            #endregion

            #region Generics[Search Example]
            Console.WriteLine("*****************search example****************");
            Console.WriteLine(Helper<int>.SearchArray([1, 2, 3, 4, 5, 7], 3));
            Console.WriteLine(Helper<string>.SearchArray(["1", "2", "3", "4", "5", "7"], "3"));
            Point point = new Point(1, 2);
            Point point2 = new Point(11, 12);
            Point point3 = new Point(12, 13);
            Point point4 = new Point(13, 14);
            Point point5 = new Point(14, 15);
            Console.WriteLine(Helper<Point>.SearchArray([point, point2, point3, point4, point5], point2));

            #endregion

            //compared refrences not object's Value
            Employe employe = new Employe()
            {
                Id = 15,
                Name = "Te555st",
                Salary = 300550
            }; 
            Employe employe2 = new Employe()
            {
                Id = 15,
                Name = "Te555st",  
                Salary=300550
            };
            Console.WriteLine(employe.Equals(employe2));
        }
    }
}
