using System;
using System.Collections.Generic;

namespace WNS
{
    class Program
    {
        static void Main(string[] args)
        {
           Wizard Bobby = new Wizard("Bobby");
           Human Jimmy = new Human("Jimmy");
           Ninja George = new Ninja("George");
           Samurai Zen = new Samurai("Zen");
           Wizard Kenny = new Wizard("Kenny");
           Samurai Kenji = new Samurai("Kenji");

           Bobby.Fireball(Jimmy);
           George.Steal(Bobby);
           George.GetAway();
           Zen.DeathBlow(George);
           Zen.DeathBlow(Kenny);
           Jimmy.Attack(Zen);
           Zen.Meditate();
           Samurai.How_Many();

        }

        
    }
}
