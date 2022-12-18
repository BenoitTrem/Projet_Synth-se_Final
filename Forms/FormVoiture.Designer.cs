namespace Projet_Synthèse_Final
{
    partial class FormVoiture
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
            this.comboBox_Modele = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Choisir = new System.Windows.Forms.Button();
            this.listBox_Prix = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Modele
            // 
            this.comboBox_Modele.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Modele.FormattingEnabled = true;
            this.comboBox_Modele.Items.AddRange(new object[] {
            "Toyota Prius",
            "Honda Civic",
            "Chevrolet Trax",
            "Toyota Corolla",
            "Volkswagen Golf",
            "Ford Mustang"});
            this.comboBox_Modele.Location = new System.Drawing.Point(26, 192);
            this.comboBox_Modele.Name = "comboBox_Modele";
            this.comboBox_Modele.Size = new System.Drawing.Size(275, 39);
            this.comboBox_Modele.TabIndex = 0;
            this.comboBox_Modele.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 82);
            this.label1.TabIndex = 3;
            this.label1.Text = "Veulliez choisir\r\n   une voiture";
            // 
            // button_Choisir
            // 
            this.button_Choisir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Choisir.Location = new System.Drawing.Point(179, 374);
            this.button_Choisir.Name = "button_Choisir";
            this.button_Choisir.Size = new System.Drawing.Size(122, 52);
            this.button_Choisir.TabIndex = 4;
            this.button_Choisir.Text = "Choisir";
            this.button_Choisir.UseVisualStyleBackColor = true;
            // 
            // listBox_Prix
            // 
            this.listBox_Prix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Prix.FormattingEnabled = true;
            this.listBox_Prix.ItemHeight = 25;
            this.listBox_Prix.Location = new System.Drawing.Point(68, 288);
            this.listBox_Prix.Name = "listBox_Prix";
            this.listBox_Prix.Size = new System.Drawing.Size(179, 29);
            this.listBox_Prix.TabIndex = 5;
            this.listBox_Prix.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Modèle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prix";
            // 
            // button_Annuler
            // 
            this.button_Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Annuler.Location = new System.Drawing.Point(26, 374);
            this.button_Annuler.Name = "button_Annuler";
            this.button_Annuler.Size = new System.Drawing.Size(122, 52);
            this.button_Annuler.TabIndex = 8;
            this.button_Annuler.Text = "Annuler";
            this.button_Annuler.UseVisualStyleBackColor = true;
            this.button_Annuler.Click += new System.EventHandler(this.button_Annuler_Click);
            // 
            // FormVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(341, 477);
            this.Controls.Add(this.button_Annuler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_Prix);
            this.Controls.Add(this.button_Choisir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Modele);
            this.Name = "FormVoiture";
            this.Text = "Louer une voiture";
            this.Load += new System.EventHandler(this.FormVoiture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Modele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Choisir;
        private System.Windows.Forms.ListBox listBox_Prix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Annuler;
    }
}