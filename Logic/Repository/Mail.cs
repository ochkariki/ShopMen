using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Repository
{
    class Mail
    {
        private string _adress;

        public string adress
        {
            get { return _adress; }
            set { _adress = value; }
        }

        private string _type;

        public string type
        {
            get { return _type; }
            set { _type = value; }
        }

        private string _text;

        public string text
        {
            get { return _text; }
            set { _text = value; }
        }
    }
}
