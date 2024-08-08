using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_AirplaneApp
{
    internal class RandomPerson
    {
        private string[] femaleNames = {
            "Emily",
            "Sophia",
            "Emma",
            "Olivia",
            "Ava",
            "Isabella",
            "Mia",
            "Charlotte",
            "Amelia",
            "Harper"
        };
        private string[] maleNames = {
            "Liam",
            "Noah",
            "Oliver",
            "Elijah",
            "William",
            "James",
            "Benjamin",
            "Lucas",
            "Henry",
            "Alexander"
        };
        private string[] lastNames = {
            "Smith",
            "Johnson",
            "Williams",
            "Jones",
            "Brown",
            "Davis",
            "Miller",
            "Wilson",
            "Moore",
            "Taylor"
        };
        private string name;
        private string gender;
        private int age, id;
        Random rndm = new Random();

        private void SetGender()
        {
            if(rndm.Next(2) == 0)
            {
                gender = "Female";
            } else
            {
                gender = "Male";
            }
        }

        private void SetAge()
        {
            age = rndm.Next(1, 70);
        }

        private void SetName()
        {
            if (gender == "Female")
            {
                name = femaleNames[rndm.Next(femaleNames.Length - 1)] + " " + lastNames[rndm.Next(lastNames.Length - 1)];
            } else
            {
                name = maleNames[rndm.Next(femaleNames.Length - 1)] + " " + lastNames[rndm.Next(lastNames.Length - 1)];
            }
        }

        private void SetId(int id)
        {
            this.id = id;
        }

        public string GetName()
        {
            return name;
        }

        public string GetGender()
        {
            return gender;
        }

        public int GetAge()
        {
            return age;
        }

        public int GetId()
        {
            return id;
        }
        public RandomPerson GeneratePerson(int id)
        {
            SetGender(); SetAge(); SetName(); SetId(id);
            RandomPerson randomPerson = new RandomPerson();
            randomPerson.id = GetId();
            randomPerson.gender = GetGender();
            randomPerson.age = GetAge();
            randomPerson.name = GetName();
            return randomPerson;
        }
    }
}
