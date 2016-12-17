using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Repository
{
    class Costume
    {
        private int _IdCostume;

        public int IdCostume
        {
            get { return _IdCostume; }
            set { _IdCostume = value; }
        }

        private string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private TypeOfCostume _type;

        public TypeOfCostume type
        {
            get { return _type; }
            set { _type = value; }
        }

        private Colour _colour;

        public Colour colour
        {
            get { return _colour; }
            set { _colour = value; }
        }

        private Size _size;
        
        public Size size
        {
            get { return _size; }
            set { _size = value; }
        }

        private int _quantity;

        public int quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
    }
}
