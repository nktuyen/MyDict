using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace nktuyen.mydict
{

    [ServiceContract]
    public interface ICountryService
    {
        [OperationContract]
        CountryServiceResponse GetAllCountries();
        [OperationContract]
        CountryServiceResponse GetCountryByID(int id);
        [OperationContract]
        CountryServiceResponse GetCountryByCode(string code);
        [OperationContract]
        CountryServiceResponse GetCountryByName(string name);
    }

    [DataContract]
    public class Country
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string ISO { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Title { get; set; }
    }

    [DataContract]
    public class CountryServiceResponse
    {
        [DataMember]
        public int Code { get; set; }
        [DataMember]
        List<Country> Data { get; set; }
    }
}