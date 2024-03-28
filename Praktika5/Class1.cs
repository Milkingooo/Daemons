using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika5
{
    public abstract class Spirit
    {
        public abstract void Passport();
    }
    public class Monster : Spirit
    {
        string name;
        int health, ammo;
        MonsterType type {  get; set; }
        public Monster()
        {
            this.health = 100;
            this.ammo = 100;
            this.name = "Noname";
        }
        public Monster(string name) : this()
        {
            this.name = name;
        }
        public Monster(int health, int ammo, string name)
        {
            this.health = health;
            this.ammo = ammo;
            this.name = name;
        }
        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                if (value > 0) health = value;
                else health = 0;
            }
        }
        public int Ammo
        {
            get
            { 
            return ammo;
            }
            set
            {
                if (value > 0) ammo = value;
                else ammo = 0;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        override public void Passport()
        {
            Console.WriteLine("Monster {0} \t health = {1} ammo = {2}", name, health, ammo);
        }
    }
    [Brain(3)]
    [MonsterType(MonsterType.Air, MonsterType.Pelmeni, MonsterType.Fire)]
    public class Daemon : Monster
    {
        public int brain;
        public MonsterType Type;
        [Brain(3)]
        public Daemon()
        {
            brain = 1;
        }
        [Brain(3)]
        public Daemon(string name,MonsterType type ,int brain) : base(name)
        {
            this.Type = type;
            this.brain = brain;
        }
        [Brain(3)]
        public Daemon(int health, int ammo, string name, MonsterType type, int brain) : base(health, ammo, name)
        {
            this.Type = type;
            this.brain = brain;
        }
        override public void Passport()
        {
            Console.WriteLine("Daemon {0} \t health = {1} ammo = {2} brain = {3}",
            Name, Health, Ammo, brain);
        }
        public void Think()
        {
            Console.Write(Name + " is");
            for (int i = 0; i < brain; ++i) Console.Write(" thinking");
            
        Console.WriteLine("...");
        }
    }


}
