using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Threading.Tasks;

namespace FranticFighters.Classes
{
    public enum ComboKey
    {
        Up = 0,
        Down = 1,
        Right = 2,
        Left = 3,
        Space = 4,
        Null = 5
    }

    class GestureSystem
    {
        private readonly Hero hero;
        private List<Combos> KnownCombos = new List<Combos>();

        public delegate void GestureActivatedEventHandler(object sender, EventArgs e);
        public event GestureActivatedEventHandler GestureSystemToggled;

        private static bool isActive = false;
        
        private Timer TurnTimer = new Timer();
        private Timer ComboTimer = new Timer();

        public GestureSystem(Hero hero)
        {
            this.hero = hero;
        }

        protected virtual void OnGestureToggle()
        {
            GestureSystemToggled?.Invoke(this, EventArgs.Empty);
        }

        public Combos CheckCombo(List<ComboKey> comboKeys) {
            bool Valid = false;
            foreach (var combo in KnownCombos)
            {
                if (combo.KeyCombo.Count == comboKeys.Count)
                {
                    Valid = ValidateCombo(combo.KeyCombo, comboKeys);
                    if (Valid)
                    {
                        return combo;
                    }
                }
            }
            return null;

        }

        private bool ValidateCombo(List<ComboKey> combokeys, List<ComboKey> combo)
        {
            for (int i = 0; i < combo.Count; i++)
            {
                if (combo[i] != combokeys[i])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
