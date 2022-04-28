namespace GameUnits
{
    public class MilitaryUnit : Unit
    {
        public int AttackPower { get; set; }
        public int XP { get; set; }
        public override int Health { get; set; }
        public override float Value { get; }

        public MilitaryUnit(int attackPower, int xp, int move, int health) 
            : base(move, health)
        {
            AttackPower = attackPower;
            XP = xp;
            Health = health + xp;
            Value = attackPower + xp;
        }

        public void Attack(Unit unit) 
        {
            
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}