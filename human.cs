using System;
using System.Collections.Generic;
namespace WNS {

    public class Human{
        public string name;
        public int strength = 3;
        public int health = 100;

        public int dexterity = 3;

        public int intelligence = 3;

        public Human(string val){
            name = val;
        }

        public Human(string val1, int val2 = 3, int val3 = 100, int val4 = 3, int val5 = 3){
            name = val1;
            strength = val2;
            health = val3;
            intelligence = val4;
            dexterity = val5;


        }

        public void Attack(Human victim){
            Human enemy = victim as Human;
            if(enemy == null){
                System.Console.WriteLine("Not a Human so you failed");
            }
            else{
                int hp = victim.health -= (this.strength * 5);
                int attack = (this.strength * 5);
                System.Console.WriteLine("{0} attacked {1} and lost {2} health and who now has {3} health", this.name,victim.name,attack,hp);
                
            }
            
        }



    }
    public class Wizard : Human{
        public Wizard(string name) : base(name){
             health = 50;
             intelligence = 25;


        }
          public void Heal(){
           int healed = this.health += (this.intelligence * 10);

            System.Console.WriteLine("{0} was healed by {1} and now has the health of {2}", this.name,healed,this.health);

        }

        public void Fireball(Human victim){
            
            Random burn = new Random();
            int sizzle = burn.Next(20,51);
            victim.health -= sizzle;

            System.Console.WriteLine("{0} FIREBALLED {1}!!!!!! {1} lost {2} health and {1} now has {3} health", this.name, victim.name, sizzle, victim.health);

           
        }
    }

    public class Ninja : Human{

        public Ninja(string name) : base(name){
            dexterity = 175;
        }

           public void Steal(Human victim){
            this.health += 10;
            victim.health -= 5;

            System.Console.WriteLine("{0} STOLE VALUABLES FROM {1}!!! {0} gaied 10 Health, {1} lost 5 Health!!!", this.name,victim.name);

        }

        public void GetAway(){
            this.health -= 15;

            System.Console.WriteLine("{0} Got away but lost 15 Health!", this.name);
        }

    }

    public class Samurai : Human{
        static int counter = 0;
        
        public Samurai(string name) : base(name){
            health = 200;

            counter++;

        }

        public void DeathBlow(Human victim){
            if(victim.health > 51){
                victim.health -= 50;
                System.Console.WriteLine("{0} ATTEMPTED A DEATH BLOW BUT {1} WAS TOO POWERFUL. {1} LOST 50 HEALTH AND NOW HAS {2} HEALTH", this.name, victim.name, victim.health);
            }
            else{
                victim.health -= 50;
                System.Console.WriteLine("{0} DEALED A DEATH BLOW TO {1}!!!!!!! {1} IS DEAD!!!!!!!!", this.name.ToUpper(), victim.name.ToUpper());
            }
            
        }
        public void Meditate(){
            this.health = 200;

            System.Console.WriteLine("{0} Meditated and now has {1} Health!!!!", this.name, this.health);

        }


        public static int How_Many(){
            System.Console.WriteLine("There are {0} Samurai ready for battle", counter);
            return counter;            

        }
    }

}