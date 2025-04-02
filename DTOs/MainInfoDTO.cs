namespace CelestialObject.DTOs
{
    public class MainInfoDTO
    {
        public string Name { get; set; }
        public string AlternateDesignation { get; set; }
        public string Type { get; set; } // Planet, Star, Galaxy, Nebula, BlackHole, etc.
        public string Constellation { get; set; }
        public double DistanceFromEarth { get; set; } // In light years
        public double Magnitude { get; set; }
        public string ImageUrl { get; set; }
    }
}
