using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4___Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Drawf> drawfs = new List<Drawf>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Once upon a time")
                {
                    break;
                }
                string[] drawfArgs = input.Split(" <>:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string name = drawfArgs[0];
                string color = drawfArgs[1];
                int physics = int.Parse(drawfArgs[2]);
                if (drawfs.Any(x => x.Name == name && x.Colour == color))
                {
                    Drawf oldDrawf = drawfs.Single(x => x.Name == name && x.Colour == color);
                    int physicsOld = oldDrawf.Physics;
                    int oldPos = drawfs.IndexOf(oldDrawf);
                    drawfs.Remove(oldDrawf);
                    drawfs.Insert(oldPos,new Drawf(name, color, Math.Max(physics, physicsOld)));
                }
                else
                {
                    drawfs.Add(new Drawf(name, color, physics));
                }
            }
            foreach (var drawf in drawfs.OrderByDescending(x => x.Physics)
                .ThenByDescending(y => drawfs.Count(z => z.Colour == y.Colour))
                )
            {
                Console.WriteLine($"({drawf.Colour}) {drawf.Name} <-> {drawf.Physics}");
            }
        }
    }
    class Drawf
    {
        public string Colour { get; set; }
        public string Name { get; set; }
        public int Physics { get; set; }
        public Drawf(string name , string color , int physics)
        {
            Name = name;
            Colour = color;
            Physics = physics;
        }
        
    }
}
