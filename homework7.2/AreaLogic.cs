
namespace homework7._2
{
    internal class AreaLogic
    {
        static void Main(string[] args)
        {

            Cone cone = new Cone();
            Console.WriteLine("enter your radius");
            double Radius = double.Parse(Console.ReadLine());
            Console.WriteLine("enter your height");
            double Height = double.Parse(Console.ReadLine());
            double AreaSurface = cone.SurfaceCalculation(Radius, Height);
            double AreaSurfaceFull = cone.GeneralSurfaceCalculation(Radius, Height);
            Console.WriteLine(AreaSurface); ;
            Console.WriteLine(AreaSurfaceFull);
            Console.ReadLine();


        }
    }
}
