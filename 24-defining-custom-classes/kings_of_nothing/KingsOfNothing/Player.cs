using System;
using System.Collections.Generic;
using System.Text;

namespace KingsOfNothing
{
    public class Player
    {
        public void Move(int deltaX, int deltaY)
        {
            this.locationX += deltaX;
            this.locationY +=  deltaY;
        }

        public void Damage(int damage)
        {
            if((this.health - damage) <= 0)
            {
                this.health = 0;
            }
            else
            {
                this.health -= damage;
            }
        }

        public bool IsAlive()
        {
            bool isAlive = false;
            if (this.health > 0)
            {
                isAlive = true;
            }
            else if(this.health <= 0)
            {
                isAlive = false;
            }
            return isAlive;
        }

        public void Heal(int amount)
        {
            if(IsAlive() == true)
            {
                if ((this.health + amount) >= 100)
                {
                    this.health = 100;
                }
                else
                {
                    this.health += amount;
                }
            }
            else
            {
                this.health = 0;
            }
            
        }

        // Getters / Setters
        public int GetX() { return locationX; }
        public void SetX(int x) { this.locationX = x; }

        public int GetY() { return locationY; }
        public void SetY(int y) { this.locationY = y; }

        public int GetHealth() { return health; }
        public void SetHealth(int health) { this.health = health; }

        // Attributes
        private int locationX = 0;
        private int locationY = 0;
        private int health = 100;
    }
}
