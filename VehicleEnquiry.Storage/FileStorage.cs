using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleEnquiry.Core.DTO;
using VehicleEnquiry.Core.IContract;


namespace VehicleEnquiry.Storage
{
    public class FileStorage : IPresistantStorage
    {
        public void AddData(IDTO data)
        {
            var _data = (EnquiryDTO)data;
            WriteXML(_data);
        }

        private  void WriteXML(EnquiryDTO data)
        {

            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(EnquiryDTO));

            var appDomain = System.AppDomain.CurrentDomain;
            var basePath = appDomain.RelativeSearchPath ?? appDomain.BaseDirectory;

            var path = basePath + "\\Enquery\\" + new Random().Next()  + "-"+  data.Name +".xml";
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, data);
            file.Close();
        }

    }
}
