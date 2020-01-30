using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Classes_Part
{
    class EntryForm
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }


        public EntryForm()
        {
            Name = string.Empty;
            Address = string.Empty;
            ZipCode = 0;
        }

        public EntryForm(string name, string address, int zipCode)
        {
            Name = string.Empty;
            Address = string.Empty;
            ZipCode = 0;
        }

    
        public override string ToString()
        {
            return Name + " " + Address + " " + ZipCode; 
        }
    }
}
