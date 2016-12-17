using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Repository
{
    enum Type
    {
        Frak, Costume, Smoking
    }

    enum Colour
    {
        Black, Grey, White
    }
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

        private Type _type;

        public Type type
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

        private int _size;
        
        public int size
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
