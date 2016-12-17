using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Repository
{
    class TypeOfCostume
    {
        private int _IdType;

        public int IdType
        {
            get { return _IdType; }
            set { _IdType = value; }
        }

        private string _type;

        public string type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
}
