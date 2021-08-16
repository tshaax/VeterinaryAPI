using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veterinary_Appointment_API.Thirdparty.DataGeneration
{
    public interface IMessageData
    {
        int MsgType { get; }

        IEnumerable<string> Create();


    }
}