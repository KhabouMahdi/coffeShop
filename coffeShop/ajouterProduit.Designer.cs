namespace coffeShop
{
    partial class AjouterProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterProduit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtprix = new System.Windows.Forms.TextBox();
            this.cbxCategorie = new System.Windows.Forms.ComboBox();
            this.imgprod = new System.Windows.Forms.PictureBox();
            this.txtdesc = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnchoisir = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgprod)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "prix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categorie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "description";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(132, 27);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(100, 20);
            this.txtnom.TabIndex = 5;
            // 
            // txtprix
            // 
            this.txtprix.Location = new System.Drawing.Point(132, 65);
            this.txtprix.Name = "txtprix";
            this.txtprix.Size = new System.Drawing.Size(100, 20);
            this.txtprix.TabIndex = 6;
            // 
            // cbxCategorie
            // 
            this.cbxCategorie.FormattingEnabled = true;
            this.cbxCategorie.Location = new System.Drawing.Point(111, 105);
            this.cbxCategorie.Name = "cbxCategorie";
            this.cbxCategorie.Size = new System.Drawing.Size(121, 21);
            this.cbxCategorie.TabIndex = 8;
            this.cbxCategorie.SelectedIndexChanged += new System.EventHandler(this.cbxCategorie_SelectedIndexChanged);
            // 
            // imgprod
            // 
            this.imgprod.Image = ((System.Drawing.Image)(resources.GetObject("imgprod.Image")));
            this.imgprod.Location = new System.Drawing.Point(132, 217);
            this.imgprod.Name = "imgprod";
            this.imgprod.Size = new System.Drawing.Size(133, 78);
            this.imgprod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgprod.TabIndex = 9;
            this.imgprod.TabStop = false;
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(132, 155);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(100, 43);
            this.txtdesc.TabIndex = 10;
            this.txtdesc.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "image";
            // 
            // btnchoisir
            // 
            this.btnchoisir.BackColor = System.Drawing.Color.BurlyWood;
            this.btnchoisir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnchoisir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchoisir.Location = new System.Drawing.Point(30, 256);
            this.btnchoisir.Name = "btnchoisir";
            this.btnchoisir.Size = new System.Drawing.Size(96, 23);
            this.btnchoisir.TabIndex = 12;
            this.btnchoisir.Text = "telecharger img";
            this.btnchoisir.UseVisualStyleBackColor = false;
            this.btnchoisir.Click += new System.EventHandler(this.btnchoisir_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.Color.BurlyWood;
            this.btnajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouter.Location = new System.Drawing.Point(180, 329);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(75, 23);
            this.btnajouter.TabIndex = 13;
            this.btnajouter.Text = "ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // AjouterProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(276, 364);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.btnchoisir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.imgprod);
            this.Controls.Add(this.cbxCategorie);
            this.Controls.Add(this.txtprix);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "AjouterProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ajouterProduit";
            this.Load += new System.EventHandler(this.ajouterProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgprod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtprix;
        private System.Windows.Forms.ComboBox cbxCategorie;
        private System.Windows.Forms.PictureBox imgprod;
        private System.Windows.Forms.RichTextBox txtdesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnchoisir;
        private System.Windows.Forms.Button btnajouter;
    }
}