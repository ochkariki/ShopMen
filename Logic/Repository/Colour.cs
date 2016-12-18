using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Repository
{
    public class Colour
    {
        private int _IdColour;

        public int ColourId
        {
            get;
            set;
        }

        private string _colour;

        public string colour
        {
            get { return _colour; }
            set { _colour = value; }
        }

    }
}
