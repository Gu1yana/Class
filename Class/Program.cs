namespace Class
{
    internal class Program
    {
        static void Main()
        {
            Student telebe = new Student("Gulyana", "Xelilova", 88, "BB104", true);
            telebe.GetInfo();
            telebe.ChechGraduation();
            telebe.GetDiplomDegree();
        }
    }
}
