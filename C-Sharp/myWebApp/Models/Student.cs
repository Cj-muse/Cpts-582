using System;

namespace myWebApp.Models
{
    public class Student {
        
        String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        int age;
        public int Age 
        {
            get { return age; }
            set { age = value; }
        }

        String registrationNumber;
        public String RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }

        }
    }
}