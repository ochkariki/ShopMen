using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Repository
{
    class Size : BaseEntity
    {


        public int SizeId
        {
            get { return base.Id; }
            set { base.Id = value; }
        }

        private string _size;

        public string size
        {
            get { return _size; }
            set { _size = value; }
        }

    }
}
