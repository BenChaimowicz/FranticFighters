using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranticFighters.Classes
{
    static class AllCombos
    {
        public static readonly List<Combos> ComboList = new List<Combos>();


    }

    class Combos
    {
        public List<ComboKey> KeyCombo { get; }
        public string ComboName { get; }
        public int MinimumLevel { get; }
        public int Cost { get; }
        public int Damage { get; set; }

        public Combos()
        {

        }

    }
}
