namespace Class
{
    internal class Program
    {
        static void Main()
        {
            Student telebe = new Student("Gulyana", "Xelilova", 45, "BB104");
            telebe.GetInfo();
            telebe.ChechGraduation();
            telebe.GetDiplomDegree();   
                      
            Console.WriteLine(telebe.IsGraduated);
        }
    }
}
