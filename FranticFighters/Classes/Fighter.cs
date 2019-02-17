using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranticFighters.Classes
{
    abstract class Fighter: Interfaces.ICanFight
    {
        private int _maxHP;
        private int _currHP;
        private int _maxSTM;
        private int _currSTM;

        public int MaxHP { get => _maxHP; set => _maxHP= value; }
        public int HP { get => _currHP; set => _currHP = value; }
        public int MaxSTM { get => _maxSTM; set => _maxSTM = value; }
        public int STM { get => _currSTM; set => _currSTM = value; }


        public void Attack()
        {

        }
        public void Defend()
        {

        }
        
    }
}
