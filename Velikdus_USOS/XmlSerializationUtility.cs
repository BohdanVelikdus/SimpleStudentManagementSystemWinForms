using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Velikdus_USOS
{
    public static class XmlSerializationUtility
    {
        public static void SerializeListToFile(List<Person> persons)
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Person>), new[] { typeof(Student), typeof(Doktorant) });
            using (var writer = new StreamWriter("PersonListData.xml"))
            {
                xmlSerializer.Serialize(writer, persons);
                MessageBox.Show("Serialization Successfully completed!");
            }
        }
        public static List<Person> DeserializeFromFileToList()
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Person>), new[] { typeof(Student), typeof(Doktorant) });
            using (var reader = new StreamReader("PersonListData.xml"))
            {
                try
                {
                    List<Person>? persons = xmlSerializer.Deserialize(reader) as List<Person>;
                    if (persons is null)
                        return new List<Person>();
                    return persons;
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return new List<Person>();
                }
            }
        }
        public static List<Person> DeserializeFromFileToList(string path)
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Person>), new[] { typeof(Student), typeof(Doktorant) });
            using (var reader = new StreamReader(path))
            {
                try
                {
                    List<Person>? persons = xmlSerializer.Deserialize(reader) as List<Person>;
                    if (persons is null)
                        return new List<Person>();
                    return persons;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return new List<Person>();
                }
            }
        }
        public static void SerializeListOfImagesToFile(List<PhotoImage> images) {
            var xmlSerializer = new XmlSerializer(typeof(List<PhotoImage>), new[] { typeof(PhotoImage) });
            using (var writer = new StreamWriter("PhotoImagesForPersons.xml")) { 
                xmlSerializer.Serialize(writer, images);
                MessageBox.Show("Serialization Successfully completed!");
            }
        }
        public static List<PhotoImage> DeserializeFromFileImages(string path) {
            var xmlSerializer = new XmlSerializer(typeof(List<PhotoImage>), new[] { typeof(PhotoImage)});
            using (var reader = new StreamReader(path))
            {
                try
                {
                    List<PhotoImage>? images = xmlSerializer.Deserialize(reader) as List<PhotoImage>;
                    if (images is null)
                        return new List<PhotoImage>();
                    return images;
                }
                catch (Exception ex)
                {
                    return new List<PhotoImage>();
                }
            }
        }


 

    }
}
