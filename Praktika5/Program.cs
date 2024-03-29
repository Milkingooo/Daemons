using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Praktika5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //     Daemon[] daemons = new Daemon[]
            //{
            //     new Daemon("Саня",MonsterType.Air, 4),
            //     new Daemon("Daemon2",MonsterType.Pelmeni, 2),
            //     new Daemon("Daemon3",MonsterType.Stone, 5)
            //};

            //     List<Daemon> validDaemons = new List<Daemon>();

            //     foreach (Daemon daemon in daemons)
            //     {
            //         if (IsValidBrainLevel(daemon))
            //         {
            //             validDaemons.Add(daemon);
            //         }
            //     }

            //     Console.WriteLine("Valid Daemon names:");
            //     foreach (Daemon validDaemon in validDaemons)
            //     {
            //         Console.WriteLine(validDaemon.Name);
            //     }
            // }

            // static bool IsValidBrainLevel(Daemon daemon)
            // {
            //     BrainAttribute attribute = Attribute.GetCustomAttribute(typeof(Daemon), typeof(BrainAttribute)) as BrainAttribute;
            //     if (attribute != null && daemon.brain >= attribute.MinimumValue)
            //     {
            //         return true;
            //     }
            //     return false;
            // }
            // private void CheckMonsterTypeAttribute(Type type, MonsterType monsterType)
            // {
            //     var monsterTypeAttribute = (MonsterTypeAttribute)Attribute.GetCustomAttribute(type, typeof(MonsterTypeAttribute));
            //     if (monsterTypeAttribute != null && !Array.Exists(monsterTypeAttribute.ValidTypes, t => t == monsterType))
            //     {
            //         throw new ArgumentException("Invalid Monster type");
            //     }
            // }

            // private void CheckBrainAttribute(System.Reflection.ConstructorInfo ctor, int value = 0)
            // {
            //     var attribute = (BrainAttribute)Attribute.GetCustomAttribute(ctor, typeof(BrainAttribute));
            //     if (attribute != null && value < attribute.MinimumValue)
            //     {
            //         throw new ArgumentException("Brain value is below minimum allowed value");
            //     }
            // }



            /*---------------------*\ 
            | Copied From Pc #12 :) | 
            \*---------------------*/



            Daemon[] daemons = new Daemon[] 
            {
            new Daemon("Daemon1", MonsterType.Air, 2),
            new Daemon("Daemon2", MonsterType.Pelmeni, 5),
            new Daemon("Daemon3", MonsterType.Fire, 3),
            new Daemon("Daemon4", MonsterType.Fire, 1),
            new Daemon("Daemon5", MonsterType.Fire, 5)
            };

            List<Daemon> validDaemons = new List<Daemon>();
            foreach (Daemon daemon in daemons)
            {
                if (CheckAttributes(daemon))
                {
                    Console.WriteLine("Attributes are valid for Daemon class.");
                    validDaemons.Add(daemon);
                }
                else
                {
                   Console.WriteLine("Attributes are not valid for Daemon class.");
                }
            }

            Console.WriteLine("Valid Daemons:");
            foreach (Daemon validDaemon in validDaemons)
            {
                Console.WriteLine(validDaemon.Name);
            }
        }
        public static bool CheckAttributes(Daemon daemon)
        {
            MonsterTypeAttribute monsterTypeAttribute = daemon.GetType().GetCustomAttribute<MonsterTypeAttribute>();
            BrainAttribute brainAttribute = daemon.GetType().GetCustomAttribute<BrainAttribute>();

            if (monsterTypeAttribute != null && brainAttribute != null)
            {
                if (monsterTypeAttribute.ValidTypes.Contains(daemon.Type) && daemon.brain >= brainAttribute.MinimumValue)
                {
                    return true;
                }
            }

            return false;
        }

    }

}
