namespace Logic.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Logic.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Logic.Context";
        }

        protected override void Seed(Logic.Context context)
        {
            //using (var sr = new StreamReader("../../../Costume.cvs"))
            //{
            //    string line = sr.ReadLine();
            //    while(line != null)
            //    {

            //    }
            //}
        }
    }
}
