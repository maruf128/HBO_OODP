// maak van de opgegeven variables een const van
const double spdOfLightInMperS = 299792458;
const double daysInYear = 365.242199;
const string planetName = "LP 890-9b";
const double distanceFromEarthInLightYear = 100;

// maak hier de berekening
double distanceFromEarthInMeters = distanceFromEarthInLightYear * spdOfLightInMperS * daysInYear * 24 * 60 * 60;

// schrijf nu de lines zoals codegrade het wilt
Console.WriteLine("The planet " + planetName + " is " + distanceFromEarthInLightYear + " lightyears away from earth");
Console.WriteLine("In meters this is " + distanceFromEarthInMeters);
