using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Employe_Form.Models
{
    [DataContract]
    public class Message<T>
    {
        [DataMember (Name = "IsSuccess")]
        public bool IsSuccess  { get; set; }
    [DataMember(Name = "ReturnMessage")]
    public bool ReturnMessage  { get; set; }
[DataMember(Name = "Data")]
public T Data  { get; set; }

    }
}