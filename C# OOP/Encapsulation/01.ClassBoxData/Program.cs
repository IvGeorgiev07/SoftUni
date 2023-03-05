using System.Text;

namespace _01.ClassBoxData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new(length, width, height);

                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Surface Area - {box.SurfaceArea():f2}");
                sb.AppendLine($"Lateral Surface Area - {box.LateralSurfaceArea():f2}");
                sb.AppendLine($"Volume - {box.Volume():f2}");
                Console.WriteLine(sb.ToString().Trim());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}