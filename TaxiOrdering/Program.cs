using System;
using System.Collections.Generic;
using System.Linq;

namespace TaxiOrdering
{
    class Program
    {
        static void Main()
        {
            var taxiProvider = new TaxiProvider(new List<Car>
            {
                new Car
                {
                    ServiceClass = ServiceClass.Economy,
                    AvailableSeatsCount = 2,
                    IsNonSmokingDriver = true,
                    IsSilentDriver = true,
                    DriveStyle = DriveStyle.Careful,
                    IsAvailable = true,
                    SpokenLanguages = new List<string> {"English", "Chinese", "Turkish"}
                },
                new Car
                {
                    AvailableSeatsCount = 3,
                    DriveStyle = DriveStyle.Standard,
                    IsAvailable = true,
                    SpokenLanguages = new List<string> {"French", "Chinese", "Romanian"}
                },
                new Car
                {
                    AvailableSeatsCount = 4,
                    IsNonSmokingDriver = true,
                    IsSilentDriver = true,
                    DriveStyle = DriveStyle.Careful,
                    SpokenLanguages = new List<string> {"Estonian", "Chinese", "Swahili"}
                }
            });
            var client = new Client(DriveStyle.Careful, ServiceClass.Economy, 2, true, true, false, "Chinese");
            client.OrderCar(taxiProvider);
            //...
        }
    }

    public class Client
    {
        private static Car preferences = null;

        public Client(DriveStyle driveStyle = DriveStyle.Careful, ServiceClass serviceClass = ServiceClass.Economy,
            int seatsCount = 2, bool likeSilent = false, bool doNotLikeSmokeer = false, bool extraLuggage = false,
            string languages = "English")
        {
            preferences = new Car()
            {
                DriveStyle = driveStyle,
                ServiceClass = serviceClass,
                AvailableSeatsCount = seatsCount,
                IsSilentDriver = likeSilent,
                IsNonSmokingDriver = doNotLikeSmokeer,
                HasExtraLuggageSpace = extraLuggage,
                SpokenLanguages = new List<string> { languages }
            };
        }

        public void SetSpecialCircumstances(TaxiProvider taxiProvider, Func<Car, Car> func)
        {
            //*** For example ***//
            taxiProvider.GetAvailableCar(DateTime.Now, func(preferences));
        }

        public Car GetPreferences { get { return preferences; } }

        public void OrderCar(TaxiProvider taxiProvider)
        {
            taxiProvider.GetAvailableCar(DateTime.Now, GetPreferences);
        }
    }

    public class TaxiProvider
    {
        public List<Car> Cars { get; }

        public TaxiProvider(List<Car> cars)
        {
            Cars = cars;
        }

        public Car GetAvailableCar(DateTime dateTime, Car clientPreferences)
        {
            if (dateTime.Date.TimeOfDay < DateTime.Now.Date.TimeOfDay)
            {
                throw new Exception("Invalid date range.");
            }
            List<Car> chosenCars = Cars.FindAll(x => x.IsAvailable);
            if(chosenCars != null)
            {
                foreach(Car tempCar in chosenCars)
                {
                    if(clientPreferences.Equals(tempCar))
                        return tempCar;
                }
            }
            throw new Exception("We haven't any car to you.");
        }
    }

    public class Car
    {
        public DriveStyle DriveStyle { get; set; }

        public ServiceClass ServiceClass { get; set; }

        public int AvailableSeatsCount { get; set; }

        public bool IsSilentDriver { get; set; }

        public bool IsNonSmokingDriver { get; set; }

        public bool HasExtraLuggageSpace { get; set; }

        public IEnumerable<string> SpokenLanguages { get; set; }

        public bool IsAvailable { get; set; }

        public override bool Equals(object obj)
        {
            bool b = obj is Car car &&
                   DriveStyle == car.DriveStyle &&
                   ServiceClass == car.ServiceClass &&
                   AvailableSeatsCount == car.AvailableSeatsCount &&
                   IsSilentDriver == car.IsSilentDriver &&
                   IsNonSmokingDriver == car.IsNonSmokingDriver &&
                   HasExtraLuggageSpace == car.HasExtraLuggageSpace;
            if (b)
            {
                foreach(string str1 in SpokenLanguages)
                {
                    foreach(string str2 in (obj as Car).SpokenLanguages)
                    {
                        if (str1.Equals(str2))
                            return b;
                    }
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(DriveStyle, ServiceClass, AvailableSeatsCount,
                IsSilentDriver, IsNonSmokingDriver, HasExtraLuggageSpace);
        }

        public void Order()
        {
        }
    }

    public enum ServiceClass
    {
        Economy,
        Standard,
        Comfortable,
        Fast,
    }

    public enum DriveStyle
    {
        Careful,
        Standard,
        Fast
    }
}
