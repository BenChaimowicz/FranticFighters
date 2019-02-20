using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranticFighters.Classes
{
    class Hero : Fighter
    {
        public int Level = 1;
        public int XP = 0;

        private GestureSystem gestureSystem;
        private List<ComboKey> CurrentCombo = new List<ComboKey>();
        

        public Hero()
        {
            GameMaster.Hero = this;
            gestureSystem = new GestureSystem(this);
        }

        public void RecordKey(ComboKey key)
        {
            if (key != ComboKey.Space)
            {
                CurrentCombo.Add(key);
            } else
            {
                gestureSystem.CheckCombo(CurrentCombo);

            }
        }

        public void Attack(ComboKey comboKey) {

        } 
    }
}
