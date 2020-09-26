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
        public string WrittenMessage { get; set; }
        public string ChooseMessage { get; set; }


        public Msg(string writtenmessage, string choosemessage)
        {
            WrittenMessage = writtenmessage;
            ChooseMessage = choosemessage;
        }
    }
}
