namespace ConsoleApp1
{
    //{2023.01.05 modify class
    
    internal class Program
    {
<<<<<<< HEAD
=======
        static void Main(string[] args)
        {
            //{2023.01.05.  Add new feature user input / beta
            string userinput = string.Empty;
            Console.WriteLine("This program convert Cm to Inch");
            Console.Write("Input Cm value : ");
            userinput= Console.ReadLine();

            int cmInput = 0;
            int.TryParse(userinput, out cmInput);
            Ruler ruler = new Ruler(cmInput);
            //}2023.01.05.  Add new feature user input / beta
            ruler.Run();
        }

>>>>>>> origin/develop
        public class Ruler
        {
            private const float ONE_INCH = 2.54f;

            public int Centimeter { get; set; } = 0;

            public float Inch
            {
                get { return Centimeter * ONE_INCH; }
                private set { Centimeter = (int)(value / ONE_INCH); }
            }
            public Ruler(int cmvalue) { Centimeter = cmvalue; }

            public void Run()
            {
                Console.WriteLine($"{Centimeter}cm 는 {Inch}inch 입니다.");
            }
        }
        //{2023.01.05 modify class

        static void Main(string[] args)
        {
            Ruler ruler = new Ruler(10);
            ruler.Run();
        }

        
    }
}