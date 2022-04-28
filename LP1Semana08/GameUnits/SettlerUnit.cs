using System.Numerics;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        public override float Value { get; }

        public SettlerUnit(int move, int health)
            : base(move,health)
        {
            Value = 5;
        }

        public void Settle(Vector2 vector2)
        {
            
        }
    }
}