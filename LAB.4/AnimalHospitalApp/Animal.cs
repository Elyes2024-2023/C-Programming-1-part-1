using System;
using System.Collections.Generic;
using System.IO;

class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public AnimalIDInfo IDInfo { get; set; }

    public string GetInfo()
    {
        return $"Name: {Name}, Age: {Age}, Owner: {IDInfo.OwnerName}, Phone: {IDInfo.OwnerPhoneNumber}";
    }
}
