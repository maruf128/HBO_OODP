// class CarFactory
// {
//     public int aantal_allowed;
//     public CarFactory(int aantal)
//     {
//         // hier doe je telkens +1 indien je een nieuwe auto maakt
//         aantal_allowed = aantal;
//     }
//     public LimitedEditionCar ProduceLimitedEditionCar()
//     {
//         if (aantal_allowed > 0)
//         {
//             // aka je doet -1 en maakt een nieuwe auto aan
//             aantal_allowed--;

//             return new LimitedEditionCar();
//         }
//         else
//         {
//             // je mag niet meer maken
//             return null;
//         }
//     }
// }

// class LimitedEditionCar
// {
//     public const string Model = "Chevrolet Camaro";
//     public readonly string ChassisNumber = "CHNO" + Counter;
//     public static int Counter;

//     public LimitedEditionCar()
//     {
//         // hier doe je telkens +1 indien je een nieuwe auto maakt
//         Counter++;
//         ChassisNumber = "CHNO" + Counter;
//     }

//     public string GetChassisNumber()
//     {
//         // geef de nummer terug
//         return ChassisNumber;
//     }
// }
