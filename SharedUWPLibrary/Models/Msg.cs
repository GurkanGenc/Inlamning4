using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace SharedUWPLibrary.Models
{
    public class Msg /*Originally Employee class*/
    {
        public string Message { get; set; }

        public Msg(string message)
        {
            Message = message;
        }
    }
}
