using System.Runtime.Serialization;

namespace OesWCFContract
{
    [DataContract]
    public class UserNameNotExistent
    {
        [DataMember]
        public string Messge { get; set; }
    }
}
