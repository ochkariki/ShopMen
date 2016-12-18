using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
using Logic.Repository;
namespace UI
{
    static class Functions
    {
        static public void For_User_Data(out List<Costume> a, string a1)
        {
            using (var DB = new Context())
            {

                IQueryable<Costume> data = from d in DB.Costumes where d.name == a1 select d;
                List<Costume> temp = new List<Costume>();
                foreach (var first in data)
                {

                    temp.Add(first);
                }
                a = temp;
            }

        }
    }
}