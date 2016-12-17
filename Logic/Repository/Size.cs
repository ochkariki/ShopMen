using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Repository
{
    class Size
    {
        private int _IdSize;

        public int IdSize
        {
            get { return _IdSize; }
            set { _IdSize = value; }
        }

        private string _size;

        public string size
        {
            get { return _size; }
            set { _size = value; }
        }
    }
}
