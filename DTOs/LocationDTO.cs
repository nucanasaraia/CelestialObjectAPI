namespace CelestialObject.DTOs
{
    public class LocationDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double RightAscension { get; set; } // Hours
        public double Declination { get; set; } // Degrees
    }
}
