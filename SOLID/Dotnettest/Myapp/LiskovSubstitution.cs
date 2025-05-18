//in below example When working with the base Vehicle class, it’s important to note that the method StartEngine assumes an ignition mechanism. 
//However, ElectricVehicle overrides this method to provide its own mechanism. If the client assumes that all vehicles start using an ignition mechanism, 
//replacing the Vehicle with an ElectricVehicle would be incorrect and violate the Liskov Substitution Principle (LSP).

//  public class Vehicle
//     {
//         public virtual void StartEngine()
//         {
//             Console.WriteLine("Starting engine using ignition and fuel.");
//         }
//     }
//     public class ElectricVehicle : Vehicle
//     {
//         public override void StartEngine()
//         {
//             Console.WriteLine("Checking battery and starting electric motor.");
//         }
//     }

//Solution: above  can be restructured as 

public abstract class Vehicle
    {
        public abstract void StartEngine();
    }
    public class GasolineVehicle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Starting engine using ignition and fuel.");
        }
    }
    public class ElectricVehicle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Checking battery and starting electric motor.");
        }
    }