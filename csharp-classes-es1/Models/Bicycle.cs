public class Bicycle
{
    public string Brand;
    public string Model;
    public int GearCount;

    public Bicycle(string brand, string model, int gearCount)
    {
        Brand = brand;
        Model = model;
        GearCount = gearCount;
    }

    public void Ride()
    {
        Console.WriteLine($"Riding at {GearCount} gear(s)");
    }
}