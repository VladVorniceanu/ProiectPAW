namespace Proiect
{
    partial class MeniuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            buttonInregistrare = new Button();
            buttonAfisareFacultati = new Button();
            buttonAfisareDosar = new Button();
            butInregFac = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(503, 72);
            label1.Name = "label1";
            label1.Size = new Size(334, 72);
            label1.TabIndex = 0;
            label1.Text = "Bine ai venit!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(313, 215);
            label2.Name = "label2";
            label2.Size = new Size(715, 54);
            label2.TabIndex = 1;
            label2.Text = "Te rugam sa alegi o optiune de mai jos:";
            // 
            // buttonInregistrare
            // 
            buttonInregistrare.Location = new Point(694, 309);
            buttonInregistrare.Name = "buttonInregistrare";
            buttonInregistrare.Size = new Size(334, 91);
            buttonInregistrare.TabIndex = 2;
            buttonInregistrare.Text = "Inregistrare student nou";
            buttonInregistrare.UseVisualStyleBackColor = true;
            buttonInregistrare.Click += buttonInregistrare_Click;
            // 
            // buttonAfisareFacultati
            // 
            buttonAfisareFacultati.Location = new Point(313, 434);
            buttonAfisareFacultati.Name = "buttonAfisareFacultati";
            buttonAfisareFacultati.Size = new Size(334, 91);
            buttonAfisareFacultati.TabIndex = 3;
            buttonAfisareFacultati.Text = "Afisare facultati";
            buttonAfisareFacultati.UseVisualStyleBackColor = true;
            // 
            // buttonAfisareDosar
            // 
            buttonAfisareDosar.Location = new Point(694, 434);
            buttonAfisareDosar.Name = "buttonAfisareDosar";
            buttonAfisareDosar.Size = new Size(334, 91);
            buttonAfisareDosar.TabIndex = 4;
            buttonAfisareDosar.Text = "Afisare studenti inscrisi";
            buttonAfisareDosar.UseVisualStyleBackColor = true;
            // 
            // butInregFac
            // 
            butInregFac.Location = new Point(313, 309);
            butInregFac.Name = "butInregFac";
            butInregFac.Size = new Size(334, 91);
            butInregFac.TabIndex = 5;
            butInregFac.Text = "Inregistrare facultate noua";
            butInregFac.UseVisualStyleBackColor = true;
            butInregFac.Click += button1_Click;
            // 
            // MeniuPrincipal
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 819);
            Controls.Add(butInregFac);
            Controls.Add(buttonAfisareDosar);
            Controls.Add(buttonAfisareFacultati);
            Controls.Add(buttonInregistrare);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MeniuPrincipal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonInregistrare;
        private Button buttonAfisareFacultati;
        private Button buttonAfisareDosar;
        private Button butInregFac;
        ErrorProvider errorProvider1;
    }
}