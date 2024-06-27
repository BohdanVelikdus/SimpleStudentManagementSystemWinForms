using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Velikdus_USOS
{
    [Serializable]
    [XmlRoot("Person")]
    public /*internal*/ abstract class Person
    {
        [XmlElement("Name")]
        public string? FirstName { get; set; }
        [XmlElement("Surname")]
        public string? LastName { get; set; }
        [XmlElement("Age")]
        public int Age { get; set; }
        [XmlIgnore]
        public bool Sex { get; set; }
        [XmlElement("Sex")]
        public string SexAsString {
            get
            {
                return Sex ? "male" : "female";
            }
            set
            {
                Sex = (value?.ToLower() == "male");
            }
        }
        [XmlElement("Photo")]
        public string? PathToPhoto { get; set; }

        [XmlElement("DeserializedKeyToPhoto")]
        public int? posPhoto { get; set; } 


        public Person(string firstName, string lastName, int age, bool sex)
        {
            
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Sex = sex;
            PathToPhoto = string.Empty; 
        }

        public Person() : this(null, null, 21, false)
        {

        }

        public Person(Person person)
        {
            this.FirstName = person.FirstName;
            this.LastName = person.LastName;
            this.Age = person.Age;
            this.Sex = person.Sex;
        }
        public virtual string GetInfo() {
            return "Name: " + this.FirstName +
                "\nSurname: " + this.LastName +
                "\nAge: " + this.Age +
                "\nSex: " + ((this.Sex) ? "Male" : "Female") + "\n";
        }

        public virtual Tuple<Tuple<string, string, string, string>, Tuple<string, string, string, string>> GetInfo(int _) {
            string name = this.FirstName;
            string surname = this.LastName;
            string age = this.Age.ToString();
            string sex = (this.Sex) ? "Male" : "Female";
            var tup = new Tuple<string, string, string, string>(name,surname,age,sex);
            return new Tuple<Tuple<string, string, string, string>, Tuple<string, string, string, string>>(tup, null);
        }
    }


    public class PersonNameComparator() : IComparer<Person>
    {
        public int Compare(Person person1, Person person2) {
            if (person1 == null && person2 == null)
                return 0;
            if (person1 == null)
                return -1;
            if (person2 == null)
                return 1;
            return string.Compare(person1.FirstName, person2.FirstName);
        }

    }
}
