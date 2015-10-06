using Dota2.Domain.Interfaces;
using Dota2.Domain.Qualities;
using Dota2.Utilities;


namespace Dota2.Domain.Entities
{
    public class Hero : IUnit
    {
        public string Name { get; private set; }

        public UnitType UType
        {
            get { return UType; }
            private set { UType = UnitType.Hero; }
        }

        public decimal HealthPoints { get; private set; }

        public decimal StartingStrength { get; private set; }
        public decimal StartingAgility { get; private set; }
        public decimal StartingIntelligence { get; private set; }

        public decimal StrengthGain { get; private set; }
        public decimal AgilityGain { get; private set; }
        public decimal IntelligenceGain { get; private set; }

        public DamageType AttackDamageType
        {
            get { return AttackDamageType; }
            private set { AttackDamageType = DamageType.Hero; }
        }


        public class HeroBuilder : IUnitBuilder
        {
            private Hero _hero;
            
            public HeroBuilder()
            {
                _hero = new Hero();
            }

            public void SetName(string name)
            {
                _hero.Name = name;
            }

            public void SetStartingStrength(decimal strength)
            {
                _hero.StartingStrength = strength;
            }

            public void SetStartingAgility(decimal agility)
            {
                _hero.StartingAgility = agility;
            }

            public void SetStartingIntelligence(decimal intelligence)
            {
                _hero.StartingIntelligence = intelligence;
            }

            public void SetStartingStats(decimal strength, decimal agility, decimal intelligence)
            {
                SetStartingStrength(strength);
                SetStartingAgility(agility);
                SetStartingIntelligence(intelligence);
            }

            public void SetStrengthGain(decimal gain) { _hero.StrengthGain = gain; }
            public void SetAgilityGain(decimal gain) { _hero.AgilityGain = gain; }
            public void SetIntelligenceGain(decimal gain) { _hero.IntelligenceGain = gain; }
            public void SetStatsGain(decimal strGain, decimal agiGain, decimal intGain)
            {
                SetStrengthGain(strGain);
                SetAgilityGain(agiGain);
                SetIntelligenceGain(intGain);
            }

            public IUnit Build()
            {
                Dota2Logger.LogInfo(string.Format("Hero: {0} Built", _hero.Name));
                return _hero;
            }
        }
    }
}