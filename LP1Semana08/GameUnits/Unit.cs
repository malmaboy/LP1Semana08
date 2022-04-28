using System;
using System.Numerics;

namespace GameUnits
{
    public abstract class Unit
    {
        private int movement;
        public virtual int Health { get; set; }
        public abstract float Value { get; }

        protected Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move(Vector2 vector)
        {
            Console.WriteLine($"It moved {vector.ToString()}");
        }

        public virtual string ToString()
        {
            return $"Health :{Health} Value: {Value}";
        }
    }
}