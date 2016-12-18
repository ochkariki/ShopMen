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
            using (var sr = new StreamReader("../Costume.csv"))
            {
                int a = 1, b = 1, c = 1, d = 1;

                string line = sr.ReadLine();

                string[] split = line.Split(';');

                while (line != null)
                {
                    if (context.Types.Count() != 0)
                    {
                        context.Types.AddOrUpdate(new Repository.TypeOfCostume { TypeOfCostumeId = a, type = split[1] });
                        a++;
                    }
                    else
                    {
                        context.Types.Add(new Repository.TypeOfCostume { TypeOfCostumeId = a, type = split[1] });
                        a++;
                    }

                    if (context.Colours.Count() != 0)
                    {
                        context.Colours.AddOrUpdate(new Repository.Colour { ColourId = b, colour = split[3] });
                        b++;
                    }
                    else
                    {
                        context.Colours.Add(new Repository.Colour { ColourId = b, colour = split[3] });
                        b++;
                    }

                    if (context.Sizes.Count() != 0)
                    {
                        context.Sizes.AddOrUpdate(new Repository.Size { SizeId = c, size = split[4] });
                        c++;
                    }
                    else
                    {
                        context.Sizes.Add(new Repository.Size { SizeId = c, size = split[4] });
                        c++;
                    }

                    var t = new Repository.TypeOfCostume();

                    foreach (var type in context.Types)
                    {
                        if (split[1] == type.type)
                            t = type;
                    }

                    var col = new Repository.Colour();

                    foreach (var colour in context.Colours)
                    {
                        if (split[3] == colour.colour)
                            col = colour;
                    }

                    var s = new Repository.Size();

                    foreach (var size in context.Sizes)
                    {
                        if (split[4] == size.size)
                            s = size;
                    }

                    int quant;
                    int.TryParse(split[5], out quant);

                    if (context.Costumes.Count() != 0)
                    {
                        context.Costumes.Add(new Repository.Costume { CostumeId = d, colour = col, name = split[2], quantity = quant, size = s, type = t });
                        d++;
                    }
                    else
                    {
                        context.Costumes.Add(new Repository.Costume { CostumeId = d, colour = col, name = split[2], quantity = quant, size = s, type = t });
                        d++;
                    }
                }
            }
        }
    }
}
