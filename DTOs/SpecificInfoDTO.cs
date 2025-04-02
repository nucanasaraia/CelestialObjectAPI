namespace CelestialObject.DTOs
{
    public class SpecificInfoDTO
    {
        public int Id { get; set; }
        // ზოგადი ინფორმაცია
        public string Name { get; set; }
        public string AlternateDesignation { get; set; }
        public string Type { get; set; } // Planet, Star, Galaxy, Nebula, BlackHole, etc.
        public string Constellation { get; set; }
        public double DistanceFromEarth { get; set; } // In light years
        public double Magnitude { get; set; }
        public string ImageUrl { get; set; }

        // სამეცნიერო მონაცემები
        public double Mass { get; set; } // In solar masses
        public double Radius { get; set; } // In km
        public double? Temperature { get; set; } // In Kelvin
        public double Age { get; set; } // In billion years
        public string Composition { get; set; }
        public string SpectralType { get; set; }

        // მდებარეობის მონაცემები
        public double RightAscension { get; set; } // Hours
        public double Declination { get; set; } // Degrees

        // აღმოჩენის ისტორია
        public DateTime DiscoveryDate { get; set; }
        public string DiscoveredBy { get; set; }
        public string DiscoveryMethod { get; set; }
        public string ResearchHistory { get; set; }

        // კლასიფიკაცია
        public string Classification { get; set; }
        public string Characteristics { get; set; }

        // ორბიტის მონაცემები
        public string OrbitingBody { get; set; }
        public double? OrbitalPeriod { get; set; } // In Earth days
        public double? OrbitalEccentricity { get; set; }
        public double? RotationPeriod { get; set; } // In Earth days

        // დამატებითი ინფორმაცია
        public bool HasExoplanets { get; set; }
        public int? ExoplanetCount { get; set; }
        public bool IsInteresting { get; set; }
        public string InterestingFacts { get; set; }
    }
}
