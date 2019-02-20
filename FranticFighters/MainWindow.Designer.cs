namespace FranticFighters
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.combatDialog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(29, 732);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(354, 32);
            this.progressBar1.TabIndex = 0;
            // 
            // combatDialog
            // 
            this.combatDialog.Location = new System.Drawing.Point(598, 183);
            this.combatDialog.Multiline = true;
            this.combatDialog.Name = "combatDialog";
            this.combatDialog.Size = new System.Drawing.Size(436, 302);
            this.combatDialog.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1593, 808);
            this.Controls.Add(this.combatDialog);
            this.Controls.Add(this.progressBar1);
            this.Name = "MainWindow";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.TextBox combatDialog;
    }
}

