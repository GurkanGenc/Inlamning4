using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedUWPLibrary.Models;

namespace SharedUWPLibrary.Models
{
    public class ComboBoxMessages : ObservableCollection<string> /*Originally Departments class*/
    {

        public ComboBoxMessages()
        {
            Add("This is a test message.");
            Add("Test me!");
            Add("Checking the message.");
        }

    }
}
