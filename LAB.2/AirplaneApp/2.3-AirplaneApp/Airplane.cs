using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _2._3_AirplaneApp
{
    internal class Airplane
    {
        public double fuelConsumption, fuelLevel, reFuelRequirement, fuelBalance;
        public int passangerCapacity, fuelCapacity, range, distance, passangerTravelling;
        public string modal;
        public List<RandomPerson> passangers;
        Random rndm = new Random();

        private void SetFuelCapacity()
        {
            fuelCapacity = rndm.Next(1000, 300000);
        }
        private void SetPassangerCapacity()
        {
            passangerCapacity = rndm.Next(10, 20);
        }

        private void SetPassangersTravelling()
        {
            passangerTravelling = rndm.Next(10, passangerCapacity);
        }

        private void SetRange() 
        {
            range = rndm.Next(100, 30000);
        }

        private void SetFuelConsumption()
        {
            fuelConsumption = fuelCapacity / range;
        }

        private void SetDistance()
        {
            distance = rndm.Next(300, range);
        }

        private void SetFuelLevel()
        {
            fuelLevel = rndm.Next(100, fuelCapacity);
        }

        private void SetReFuelRequirement()
        {
            if (distance * fuelConsumption >  fuelLevel) {
                reFuelRequirement = distance * fuelConsumption - fuelLevel;
            } else
            {
                reFuelRequirement = 0;
            }
        }

        private RandomPerson GeneratePerson(int id)
        {
            RandomPerson newPerson = new RandomPerson();
            RandomPerson p = newPerson.GeneratePerson(id);
            return newPerson.GeneratePerson(id);
        }

        private void SetFuelBalance()
        {
            fuelBalance = fuelLevel + reFuelRequirement - (distance * fuelConsumption); 
        }

        public Airplane GenerateAirplane(string name)
        {
            SetPassangerCapacity(); SetFuelCapacity(); SetRange(); SetFuelConsumption(); SetDistance(); SetFuelLevel(); SetReFuelRequirement(); SetPassangersTravelling(); SetFuelBalance();
            Airplane airplane = new Airplane();
            airplane.fuelCapacity = fuelCapacity;
            airplane.passangerCapacity = passangerCapacity;
            airplane.passangerTravelling = passangerTravelling;
            airplane.fuelConsumption = fuelConsumption;
            airplane.distance = distance;
            airplane.fuelLevel = fuelLevel;
            airplane.reFuelRequirement = reFuelRequirement;
            airplane.range = range;
            airplane.modal = name;
            airplane.passangers = new List<RandomPerson>();
            for (int i = 0; i < passangerTravelling; i++)
            {
                airplane.passangers.Add(GeneratePerson(i));
            }
            airplane.fuelBalance = fuelBalance;
            return airplane;
        }
    }
}
