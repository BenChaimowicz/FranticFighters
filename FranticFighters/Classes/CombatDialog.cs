using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranticFighters.Classes
{
    class CombatDialog
    {
        private readonly MainWindow mainWindow;

        public CombatDialog(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        public void DisplayMessage(string msg)
        {
            mainWindow.CombatDialogText = msg;
        }
    }
}
