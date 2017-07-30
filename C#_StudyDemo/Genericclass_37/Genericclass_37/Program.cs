using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Genericclass_37
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm<Animal> farm = new Farm<Animal>();
            farm.Animals.Add(new Cow("Rual"));
            farm.Animals.Add(new Chicken("Donna"));
            farm.Animals.Add(new Chicken("Mary"));
            farm.Animals.Add(new SuperCow("Ben"));
            farm.MakeNoises();
            Farm<Cow> dairyFarm = farm.GetCows();
            dairyFarm.FeedTheAnimals();
            foreach (Cow cow in dairyFarm)
            {
                if (cow is SuperCow)
                {
                    SuperCow newCow = cow as SuperCow;
                    try
                    {
                        newCow.Fly();
                    }
                    catch (NullReferenceException nullre)
                    {                    
                        WriteLine("cow is null");
                    }                                                                               
                }          
            }
            ReadKey();
        }
    }
}
