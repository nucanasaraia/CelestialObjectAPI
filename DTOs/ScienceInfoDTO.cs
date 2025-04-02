namespace CelestialObject.DTOs
{
    public class ScienceInfoDTO
    {
        public string Name { get; set; }
        public double Mass { get; set; } // In solar masses
        public double Radius { get; set; } // In km
        public double? Temperature { get; set; } // In Kelvin
        public double Age { get; set; } // In billion years
        public string Composition { get; set; }
        public string SpectralType { get; set; }
    }
}
