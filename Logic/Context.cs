using Logic.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Context : DbContext
    {
        public DbSet<Costume> Costumes { get; set; }

        public DbSet<TypeOfCostume> Types { get; set; }

        public DbSet<Size> Sizes { get; set; }

        public DbSet<Colour> Colours { get; set; }
    }
}
