﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FranticFighters.Classes;

namespace FranticFighters
{
    public partial class MainWindow : Form
    {
        private readonly CombatDialog dialogHandler; 

        public MainWindow()
        {
            InitializeComponent();
            KeyPreview = true;

            dialogHandler = new CombatDialog(this);
            GameMaster.Hero = new Hero();
        }

        public void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                GameMaster.Hero.RecordKey(ComboKey.Up);
        
            if (e.KeyCode == Keys.Down)
                GameMaster.Hero.RecordKey(ComboKey.Down);

            if (e.KeyCode == Keys.Right)
                GameMaster.Hero.RecordKey(ComboKey.Right);

            if (e.KeyCode == Keys.Left)
                GameMaster.Hero.RecordKey(ComboKey.Left);

            if (e.KeyCode == Keys.Space)
                GameMaster.Hero.RecordKey(ComboKey.Space);
        }

        public string CombatDialogText {
            get { return combatDialog.Text; }
            set { combatDialog.Text = value; }
        }
    }
}
