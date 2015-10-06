using Dota2.Domain.Qualities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dota2.Domain.Entities
{
    public class Spell
    {
        public string Name { get; private set; }
        public DamageType SpellDamageType { get; private set; }
        public decimal CastRange { get; private set; }

        public class SpellBuilder
        {

        }
    }
}
