using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace nktuyen.mydict
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        UserServiceResponse GetAllUsers();
        [OperationContract]
        UserServiceResponse GetUserById(string id);
        [OperationContract]
        UserServiceResponse GetUserByEmail(string email);
        [OperationContract]
        UserServiceResponse GetUserByName(string name);
        [OperationContract]
        UserServiceResponse Authenticate(string name, string pasword);
    }


    [DataContract]
    public class User
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public int BirthDay { get; set; }
        [DataMember]
        public int BirthMonth { get; set; }
        [DataMember]
        public int BirthYer { get; set; }
        [DataMember]
        public DateTime Registered { get; set; }
        [DataMember]
        public int Type { get; set; }
    }

    [DataContract]
    public class UserServiceResponse
    {
        [DataMember]
        public int Code { get; set; }
        [DataMember]
        List<User> Data { get; set; }
    }
}