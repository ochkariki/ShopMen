using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Repository
{
    class Colour : BaseEntity
    {

        public int ColourId
        {
            get { return base.Id; }
            set { base.Id = value; }
        }

        private string _colour;

        public string colour
        {
            get { return _colour; }
            set { _colour = value; }
        }

    }
}
