using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using Velikdus_USOS.Interface;

namespace Velikdus_USOS
{
    [Serializable]
    public /*internal*/ class Student : Person, IBasicInfo, IDetails
    {
        [XmlElement("Id")]
        public string Id { get; set; }
        [XmlElement("Course")]
        public int Course { get; set; }
        [XmlElement("Avarage")]
        public double Avarage { get; set; }
        [XmlElement("Major")]
        public string? Major { get; set; }
        [XmlIgnore]
        public bool IsContract { get; set; }
        [XmlElement("IfContract")]


        string IBasicInfo.FirstName { get { return this.FirstName; } }
        string IBasicInfo.LastName { get { return this.LastName; } }
        int IBasicInfo.Age { get { return this.Age; } }
        bool IBasicInfo.Sex { get { return this.Sex; } }
        

        
        string IDetails.Card { 
            get {
                if (this is Doktorant) {
                    throw new Exception("Wrong function to use with this type of class");
                }
                return "-1";
            }
        }
        string IDetails.Topic
        {
            get
            {
                if (this is Doktorant)
                {
                    throw new Exception("Wrong function to use with this type of class");
                }
                return "-1";
            }
        }
        string IDetails.Sala {
            get
            {
                if (this is Doktorant)
                {
                    throw new Exception("Wrong function to use with this type of class");
                }
                return "-1";
            }
        }
        string IDetails.Advisor {
            get
            {
                if (this is Doktorant)
                {
                    throw new Exception("Wrong function to use with this type of class");
                }
                return "-1";
            }
        }
        int IDetails.WrittenArticles
        {
            get
            {
                if (this is Doktorant)
                {
                    throw new Exception("Wrong function to use with this type of class");
                }
                return -1;
            }
        }
        List<string> IDetails.GetInfoDoktorant() {
            throw new Exception("Wrong function to use with this type of class");
            return new List<string>();
        }

        string IDetails.Id { get { return this.Id; } }
        int IDetails.Course {  get { return this.Course; } }
        double IDetails.Avarage { get { return this.Avarage; } }
        string IDetails.Major { get { return this.Major; } }
        bool IDetails.IsContract { get { return this.IsContract; } }
        bool IDetails.IsInternationalStudent { get { return  this.IsInternationalStudent; } }

        List<string> IDetails.GetInfoStudent()
        {
            IDetails details = this;
            List<string> info = new List<string>()
            {
                "Id: " + details.Id,
                "Course: " + details.Course,
                "Avarage: " + details.Avarage,
                "Major: " + details.Major,
                "IsContract: " + ( (details.IsContract) ? "Contract" : "NOT contract").ToString(),
                "IsInternational: " + ( (details.IsInternationalStudent) ? "International" : "NOT international").ToString()
            };
            return info;
        }




        List<string> IBasicInfo.GetInfo() {
            IBasicInfo iBasicInfo = this;
            IDetails dl = this;
             
            List<string> info = new List<string>() { 
                "Name: " + iBasicInfo.FirstName,
                "Surname: " + iBasicInfo.LastName,
                "Age: " + iBasicInfo.Age,
                "Sex: " + iBasicInfo.Sex
            };
            return info;
        }


        public string IsContractAsString {
            get {
                return IsContract ? "Contract" : "NOT Contract";
            }
            set {
                IsContract = (value?.ToLower() == "contract");
            }
        }
        [XmlIgnore]
        public bool IsInternationalStudent { get; set; }
        [XmlElement("IfInternational")]
        public string IsInternationalAsString
        {
            get
            {
                return IsInternationalStudent ? "International" : "NOT International";
            }
            set
            {
                IsInternationalStudent = (value?.ToLower() == "international");
            }
        }

        [XmlIgnore]
        private Collection<double>? _Marks;
        [XmlIgnore]
        public IEnumerable<double> Marks
        {
            get
            {
                return _Marks;
            }
            set
            {
                CountAvarage(value);
            }

        }
        [XmlElement("Marks")]
        public string MarksAsString
        {
            get {
                string res = "";
                if (_Marks is null || _Marks.Count() == 0)
                    return "";
                foreach (var mark in _Marks) {
                    res += mark.ToString() + " ";
                }
                res = res.Trim();
                return res;
            }
            set {
                if (value == "" || value.Count() == 0)
                { 
                    Marks = new Collection<double>();
                    return;
                }   
                string[] marks = value.Split(' ');
                Collection<double> coll = new Collection<double>();
                foreach (var mark in marks) {
                    coll.Add(Convert.ToDouble(mark)); 
                }
                Marks = coll;
            }
        }

        public static bool IsNumericType<T>()
        {
            Type type = typeof(T);

            return type == typeof(int) ||
                   type == typeof(float) ||
                   type == typeof(double) ||
                   type == typeof(decimal) ||
                   type == typeof(short) ||
                   type == typeof(ushort) ||
                   type == typeof(long) ||
                   type == typeof(ulong) ||
                   type == typeof(byte) ||
                   type == typeof(sbyte);
        }

        private void CountAvarage<T>(IEnumerable<T> enumerable)
        {
            if (IsNumericType<T>())
            {
                if (enumerable.Count() == 0)
                {
                    Avarage = 3;
                    _Marks = new Collection<double>();
                    return;
                }    
                double sum = 0;
                _Marks = new Collection<double>();
                foreach (T elem in enumerable)
                {
                    sum += Convert.ToDouble(elem);
                    _Marks.Add(Convert.ToDouble(elem));
                }
                sum /= enumerable.ToArray().Length;
                Avarage = sum;
            }
        }

        public Student() : base()
        {

        }

        public Student(string firstName, string lastName, int age, bool sex) : base(firstName, lastName, age, sex)
        {

        }
        public Student(string firstName, string lastName, int age, bool sex, string id, int course, double avarage, string major, bool isContract, bool isInternational) : base(firstName, lastName, age, sex)
        {
            this.Id = id;
            this.Course = course;
            this.Avarage = avarage;
            this.Major = major;
            this.IsContract = isContract;
            this.IsInternationalStudent = isInternational;
        }

        public Student(string firstName, string lastName, int age, bool sex, string id, int course, string major, bool isContract, bool isInternational) : base(firstName, lastName, age, sex)
        {
            this.Id = id;
            this.Course = course;
            this.Major = major;
            this.IsContract = isContract;
            this.IsInternationalStudent = isInternational;
        }

        public Student(Student student) : base(student.FirstName, student.LastName, student.Age, student.Sex)
        {
            this.Id = student.Id;
            this.Course = student.Course;
            this.Avarage = student.Avarage;
            this.Major = student.Major;
            this.IsContract = student.IsContract;
            this.IsInternationalStudent = student.IsInternationalStudent;
        }

        public override string GetInfo()
        {
            return base.GetInfo() +
                "Id: " + this.Id +
                "\nCourse: " + this.Course +
                "\nAvarage: " + this.Avarage +
                "\nMajor: " + this.Major +
                "\n" + ((this.IsContract) ? "This student is on Contract" : "This student is NOT on Contract") +
                "\n" + ((this.IsInternationalStudent) ? "International student" : "Inside student") +
                "\n";
        }

        public override Tuple<Tuple<string, string, string, string>, Tuple<string, string, string, string>> GetInfo(int _) {
            return new Tuple<Tuple<string, string, string, string>, Tuple<string, string, string, string>>(base.GetInfo(1).Item1,new Tuple<string, string, string,string>(this.Id, this.Course.ToString(), this.Avarage.ToString(), this.Major));
        }

        public bool IfCanGetScholarship()
        {
            return (this.Avarage > 4.0) ? true : false;
        }

        private double AnalyzeMarks()
        {
            return this.Marks.Max() / this.Marks.Min();
        }

        public int CountScolarship()
        {
            if (!IfCanGetScholarship())
                return 0;

            double analisise = AnalyzeMarks();
            if (analisise > 0.9)
            {
                return 3000;
            }
            else if (analisise > 0.7)
            {
                return 2000;
            }
            return 1500;
        }

        public static bool operator ==(Student? student1, Student? student2) {
            if (ReferenceEquals(student1, student2))
                return true;
            if (student1 is null || student2 is null)
                return false;

            return student1.Id == student2.Id;
        }

        public static bool operator !=(Student? student1, Student? student2)
        {
            return !(student1 == student2);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Student))
                return false;
            Student other = (Student)obj;
            return this == other; 
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        
    }
}