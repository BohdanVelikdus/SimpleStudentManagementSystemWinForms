using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Velikdus_USOS
{
    [XmlRoot]
    public class PhotoImage
    {
        [XmlIgnore]
        public Image? image { get; set; }
        
        [XmlIgnore]
        public string? PathToPhoto { get; set; }

        public PhotoImage(string path) {
            PathToPhoto = path;
            try {
                image = Image.FromFile(PathToPhoto);
            }catch (Exception ex)
            {
                image = null;
            }
        }

        public PhotoImage() {
            PathToPhoto = null;
            image = null;
        }

        [XmlElement("ImageData")]
        public byte[] ImageData
        {
            get {
               using (MemoryStream ms = new MemoryStream())
               {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
               }
            }
            set {
                using (MemoryStream ms = new MemoryStream(value))
                {
                    try
                    {
                        image = Image.FromStream(ms);
                    }
                    catch (Exception e){
                        image = null;
                    }
                }
            }
        }

    }
}
