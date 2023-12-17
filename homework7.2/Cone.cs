namespace homework7._2
{
    public class Cone
    {
        public double Radius;
        public double Height;
        private double AreaSurface;
        private double AreaSurfaceFull;
        


        public double SurfaceCalculation(double Radius, double Height)
        {
            double AreaSurface = Radius * Radius * Math.PI;

            return AreaSurface;
        }

        public double GeneralSurfaceCalculation(double Radius, double Height)
        {

            double AreaSurfaceFull = (((Radius * Radius) * Math.PI) + Math.Sqrt((Radius * Radius) + (Height * Height)));

            return AreaSurfaceFull;
        }
    }
}
