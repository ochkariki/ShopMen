using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Repository
{
    class User
    {
        private List<Costume> _costumes;

        public List<Costume> costumes
        {
            get { return _costumes; }
            set { _costumes = value; }
        }

        private int _sum;

        public int sum
        {
            get { return _sum; }
            set { _sum = value; }
        }
    }
}
