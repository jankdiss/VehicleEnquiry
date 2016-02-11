using VehicleEnquiry.Core.DTO;
using VehicleEnquiry.Core.IContract;

namespace VehicleEnquiry.Storage.PresistenceStorage
{
    public class FileStorage : IPresistantStorage
    {
        public void AddData(IDTO data)
        {
            var _data = (EnquiryDTO)data;
        }
    }
}
