namespace Group19_Lab2_Winforms_Oosu
{
    partial class SäljareFrm
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
            listBoxMinaAnnonser = new ListBox();
            lblTitel = new Label();
            txtTitel = new TextBox();
            lblPris = new Label();
            txtPris = new TextBox();
            lblTyp = new Label();
            cmbTyp = new ComboBox();
            lblSkick = new Label();
            cmbSkick = new ComboBox();
            lblKurs = new Label();
            cmbKurs = new ComboBox();
            lblExtra1 = new Label();
            txtExtra1 = new TextBox();
            lblExtra2 = new Label();
            txtExtra2 = new TextBox();
            lblExtra3 = new Label();
            txtExtra3 = new TextBox();
            btnSkapa = new Button();
            btnUppdatera = new Button();
            btnTaBort = new Button();
            btnTillbaka = new Button();
            SuspendLayout();
            // 
            // listBoxMinaAnnonser
            // 
            listBoxMinaAnnonser.FormattingEnabled = true;
            listBoxMinaAnnonser.ItemHeight = 15;
            listBoxMinaAnnonser.Location = new Point(12, 12);
            listBoxMinaAnnonser.Name = "listBoxMinaAnnonser";
            listBoxMinaAnnonser.Size = new Size(430, 364);
            listBoxMinaAnnonser.TabIndex = 0;
            listBoxMinaAnnonser.SelectedIndexChanged += listBoxMinaAnnonser_SelectedIndexChanged;
            // 
            // labels and input fields
            // 
            lblTitel.AutoSize = true;
            lblTitel.Location = new Point(465, 15);
            lblTitel.Text = "Titel:";
            txtTitel.Location = new Point(555, 12);
            txtTitel.Name = "txtTitel";
            txtTitel.Size = new Size(220, 23);
            lblPris.AutoSize = true;
            lblPris.Location = new Point(465, 50);
            lblPris.Text = "Pris:";
            txtPris.Location = new Point(555, 47);
            txtPris.Name = "txtPris";
            txtPris.Size = new Size(220, 23);
            lblTyp.AutoSize = true;
            lblTyp.Location = new Point(465, 85);
            lblTyp.Text = "Typ:";
            cmbTyp.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTyp.FormattingEnabled = true;
            cmbTyp.Location = new Point(555, 82);
            cmbTyp.Name = "cmbTyp";
            cmbTyp.Size = new Size(220, 23);
            cmbTyp.SelectedIndexChanged += cmbTyp_SelectedIndexChanged;
            lblSkick.AutoSize = true;
            lblSkick.Location = new Point(465, 120);
            lblSkick.Text = "Skick:";
            cmbSkick.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSkick.FormattingEnabled = true;
            cmbSkick.Location = new Point(555, 117);
            cmbSkick.Name = "cmbSkick";
            cmbSkick.Size = new Size(220, 23);
            lblKurs.AutoSize = true;
            lblKurs.Location = new Point(465, 155);
            lblKurs.Text = "Kurs:";
            cmbKurs.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKurs.FormattingEnabled = true;
            cmbKurs.Location = new Point(555, 152);
            cmbKurs.Name = "cmbKurs";
            cmbKurs.Size = new Size(220, 23);
            lblExtra1.AutoSize = true;
            lblExtra1.Location = new Point(465, 190);
            lblExtra1.Text = "ISBN:";
            txtExtra1.Location = new Point(555, 187);
            txtExtra1.Name = "txtExtra1";
            txtExtra1.Size = new Size(220, 23);
            lblExtra2.AutoSize = true;
            lblExtra2.Location = new Point(465, 225);
            lblExtra2.Text = "Författare:";
            txtExtra2.Location = new Point(555, 222);
            txtExtra2.Name = "txtExtra2";
            txtExtra2.Size = new Size(220, 23);
            lblExtra3.AutoSize = true;
            lblExtra3.Location = new Point(465, 260);
            lblExtra3.Text = "Upplaga:";
            txtExtra3.Location = new Point(555, 257);
            txtExtra3.Name = "txtExtra3";
            txtExtra3.Size = new Size(220, 23);
            // 
            // buttons
            // 
            btnSkapa.Location = new Point(465, 305);
            btnSkapa.Name = "btnSkapa";
            btnSkapa.Size = new Size(98, 30);
            btnSkapa.Text = "Skapa";
            btnSkapa.UseVisualStyleBackColor = true;
            btnSkapa.Click += btnSkapa_Click;
            btnUppdatera.Location = new Point(570, 305);
            btnUppdatera.Name = "btnUppdatera";
            btnUppdatera.Size = new Size(98, 30);
            btnUppdatera.Text = "Uppdatera";
            btnUppdatera.UseVisualStyleBackColor = true;
            btnUppdatera.Click += btnUppdatera_Click;
            btnTaBort.Location = new Point(675, 305);
            btnTaBort.Name = "btnTaBort";
            btnTaBort.Size = new Size(100, 30);
            btnTaBort.Text = "Ta bort";
            btnTaBort.UseVisualStyleBackColor = true;
            btnTaBort.Click += btnTaBort_Click;
            btnTillbaka.Location = new Point(675, 346);
            btnTillbaka.Name = "btnTillbaka";
            btnTillbaka.Size = new Size(100, 30);
            btnTillbaka.Text = "Tillbaka";
            btnTillbaka.UseVisualStyleBackColor = true;
            btnTillbaka.Click += btnTillbaka_Click;
            // 
            // SäljareFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(btnTillbaka);
            Controls.Add(btnTaBort);
            Controls.Add(btnUppdatera);
            Controls.Add(btnSkapa);
            Controls.Add(txtExtra3);
            Controls.Add(lblExtra3);
            Controls.Add(txtExtra2);
            Controls.Add(lblExtra2);
            Controls.Add(txtExtra1);
            Controls.Add(lblExtra1);
            Controls.Add(cmbKurs);
            Controls.Add(lblKurs);
            Controls.Add(cmbSkick);
            Controls.Add(lblSkick);
            Controls.Add(cmbTyp);
            Controls.Add(lblTyp);
            Controls.Add(txtPris);
            Controls.Add(lblPris);
            Controls.Add(txtTitel);
            Controls.Add(lblTitel);
            Controls.Add(listBoxMinaAnnonser);
            Name = "SäljareFrm";
            Text = "Hantera annons";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxMinaAnnonser;
        private Label lblTitel;
        private TextBox txtTitel;
        private Label lblPris;
        private TextBox txtPris;
        private Label lblTyp;
        private ComboBox cmbTyp;
        private Label lblSkick;
        private ComboBox cmbSkick;
        private Label lblKurs;
        private ComboBox cmbKurs;
        private Label lblExtra1;
        private TextBox txtExtra1;
        private Label lblExtra2;
        private TextBox txtExtra2;
        private Label lblExtra3;
        private TextBox txtExtra3;
        private Button btnSkapa;
        private Button btnUppdatera;
        private Button btnTaBort;
        private Button btnTillbaka;
    }
}