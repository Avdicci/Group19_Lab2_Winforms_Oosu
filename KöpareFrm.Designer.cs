namespace Group19_Lab2_Winforms_Oosu
{
    partial class KöpareFrm
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
            listBoxAnnonser = new ListBox();
            btnReservera = new Button();
            btnTillbaka = new Button();
            SuspendLayout();
            //
            // listBoxAnnonser
            //
            listBoxAnnonser.FormattingEnabled = true;
            listBoxAnnonser.ItemHeight = 15;
            listBoxAnnonser.Location = new Point(12, 12);
            listBoxAnnonser.Name = "listBoxAnnonser";
            listBoxAnnonser.Size = new Size(774, 334);
            listBoxAnnonser.TabIndex = 0;
            //
            // btnReservera
            //
            btnReservera.Location = new Point(12, 365);
            btnReservera.Name = "btnReservera";
            btnReservera.Size = new Size(120, 30);
            btnReservera.TabIndex = 1;
            btnReservera.Text = "Reservera";
            btnReservera.UseVisualStyleBackColor = true;
            btnReservera.Click += btnReservera_Click;
            //
            // btnTillbaka
            //
            btnTillbaka.Location = new Point(447, 365);
            btnTillbaka.Name = "btnTillbaka";
            btnTillbaka.Size = new Size(125, 30);
            btnTillbaka.TabIndex = 2;
            btnTillbaka.Text = "Tillbaka";
            btnTillbaka.UseVisualStyleBackColor = true;
            btnTillbaka.Click += btnTillbaka_Click;
            //
            // KöpareFrm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 413);
            Controls.Add(btnTillbaka);
            Controls.Add(btnReservera);
            Controls.Add(listBoxAnnonser);
            Name = "KöpareFrm";
            Text = "Köpare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxAnnonser;
        private Button btnReservera;
        private Button btnTillbaka;
    }
}