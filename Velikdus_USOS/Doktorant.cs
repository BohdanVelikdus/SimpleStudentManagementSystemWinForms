using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Velikdus_USOS.Interface;

namespace Velikdus_USOS
{
    [Serializable]
    public /*internal*/ class Doktorant : Person, IBasicInfo, IDetails
    {
        [XmlElement("Card")]
        public string? Card { get; set; }
        [XmlElement("Topic")]
        public string? Topic { get; set; }
        [XmlElement("Sala")]
        public string? Sala { get; set; }
        [XmlElement("Advisor")]
        public string? Advisor { get; set; }
        [XmlElement("CountWrittenArticles")]
        public int WrittenArticle { get; set; }
        [XmlIgnore]
        private Collection<string>? _ArticlesPath;
        [XmlIgnore]
        public IEnumerable<string> ArticlesPath
        {
            get
            {
                return _ArticlesPath;
            }
            set
            {
                SortAlphabetic(value);
            }

        }
        [XmlElement("ArticlesPath")]
        public string PathsAsString
        {
            get {
                string res = "";
                if (ArticlesPath is null || ArticlesPath.Count() == 0) {
                    return "";
                }
                foreach (var path in ArticlesPath) {
                    res += path + " ";
                }
                res = res.Trim();
                return res;
            }
            set {
                string[] paths = value.Split(' ');
                Collection<string> coll = [.. paths];
                ArticlesPath = coll;
            }
        }
        //base 
        public new string FirstName { get => base.FirstName; }
        public new string LastName { get => this.LastName; }
        public new int Age { get => this.Age; }
        public new bool Sex { get  => this.Sex; }
        List<string> IBasicInfo.GetInfo()
        {
            IBasicInfo iBasicInfo = this;
            List<string> info = new List<string>() {
                "Name: " + iBasicInfo.FirstName,
                "Surname: " + iBasicInfo.LastName,
                "Age: " + iBasicInfo.Age,
                "Sex: " + iBasicInfo.Sex
            };
            return info;
        }
        // IDetailse
        public int WrittenArticles { get { return this.WrittenArticle; } }

        public string Id => throw new NotImplementedException();

        public int Course => throw new NotImplementedException();

        public double Avarage => throw new NotImplementedException();

        public string Major => throw new NotImplementedException();

        public bool IsContract => throw new NotImplementedException();
        public bool IsInternationalStudent => throw new NotImplementedException();
        public List<string> GetInfoStudent()
        {
            throw new NotImplementedException();
        }
        public List<string> GetInfoDoktorant() { 
            IDetails details = this;
            List<string> info = new List<string>()
            {
                "Card: " + details.Card,
                "Topic: " + details.Topic,
                "Sala: " + details.Sala,
                "Advisor: " + details.Advisor,
                "Written Articles: " + details.WrittenArticles
            };
            return info;
        }









        private void SortAlphabetic(IEnumerable<string> enumerable)
        {
            _ArticlesPath = new Collection<string>(enumerable.OrderBy(x => x.Length).ToList());
        }

        public Doktorant() : base() { }

        public Doktorant(string firstName, string lastName, int age, bool sex) : base(firstName, lastName, age, sex)
        {

        }
        public Doktorant(string firstName, string lastName, int age, bool sex, string card, string topic, string sala, string advisor, int writtenArticle) : base(firstName, lastName, age, sex)
        {
            Card = card;
            Topic = topic;
            Sala = sala;
            Advisor = advisor;
            WrittenArticle = writtenArticle;
        }
        public Doktorant(Doktorant other) : base(other.FirstName, other.LastName, other.Age, other.Sex)
        {
            this.Card = other.Card;
            this.Topic = other.Topic;
            this.Sala = other.Sala;
            this.Advisor = other.Advisor;
            this.WrittenArticle = other.WrittenArticle;
        }
        public override string GetInfo()
        {
            return base.GetInfo() +
                "Card: " + this.Card +
                "\nTopic: " + this.Topic +
                "\nSala: " + this.Sala +
                "\nAdvisor: " + this.Advisor +
                "\nCount of written articles: " + this.WrittenArticle +
                "\n";
        }

        public override Tuple<Tuple<string, string, string, string>, Tuple<string, string, string, string>> GetInfo(int _)
        {
            return new Tuple<Tuple<string, string, string, string>, Tuple<string, string, string, string>>(base.GetInfo(5).Item1, new Tuple<string, string, string, string>(this.Card, this.Topic, this.Sala, this.Advisor));
        }

        public static bool operator ==(Doktorant? doktorant1, Doktorant? doktorant2)
        {
            if(ReferenceEquals(doktorant1, doktorant2))
                return true;
            if (doktorant1 is null || doktorant2 is null)
                return false;

            return doktorant1.Card == doktorant2.Card;
        }

        public static bool operator !=(Doktorant? doktorant1, Doktorant? doktorant2)
        {
            return !(doktorant1 == doktorant2);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Doktorant))
                return false;
            Doktorant other = (Doktorant)obj;
            return this == other;
        }

        public override int GetHashCode()
        {
            return Card.GetHashCode();  
        }

        
    }
}
