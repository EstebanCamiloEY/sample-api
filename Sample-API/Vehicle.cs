namespace Sample_API
{
    public interface IVehicle
    {
        void StartUp();
    }

    public class Car : IVehicle
    {
        public void StartUp()
        {
            Console.WriteLine("El coche arranca.");
        }
    }

    public class Motorcycle : IVehicle
    {
        public void StartUp()
        {
            Console.WriteLine("La moto arranca.");
        }
    }
}
