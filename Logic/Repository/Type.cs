using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Repository
{
    public class TypeOfCostume : BaseEntity
    {


        public int TypeOfCostumeId
        {
            get { return base.Id; }
            set { base.Id = value; }
        }

        private string _type;

        public string type
        {
            get { return _type; }
            set { _type = value; }
        }

    }
}
