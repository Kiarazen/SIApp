using System;

using Xamarin.Forms;

namespace SPL.Directory
{
    public class Results
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public string ImageSource{ get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

