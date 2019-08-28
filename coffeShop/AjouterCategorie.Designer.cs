namespace coffeShop
{
    partial class AjouterCategorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterCategorie));
            this.btnajouterCat = new System.Windows.Forms.Button();
            this.btnchoisir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.imagecat = new System.Windows.Forms.PictureBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagecat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnajouterCat
            // 
            this.btnajouterCat.BackColor = System.Drawing.Color.BurlyWood;
            this.btnajouterCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnajouterCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouterCat.Location = new System.Drawing.Point(164, 327);
            this.btnajouterCat.Name = "btnajouterCat";
            this.btnajouterCat.Size = new System.Drawing.Size(75, 25);
            this.btnajouterCat.TabIndex = 25;
            this.btnajouterCat.Text = "ajouter";
            this.btnajouterCat.UseVisualStyleBackColor = false;
            this.btnajouterCat.Click += new System.EventHandler(this.btnajouterCat_Click);
            // 
            // btnchoisir
            // 
            this.btnchoisir.BackColor = System.Drawing.Color.BurlyWood;
            this.btnchoisir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnchoisir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchoisir.Location = new System.Drawing.Point(14, 205);
            this.btnchoisir.Name = "btnchoisir";
            this.btnchoisir.Size = new System.Drawing.Size(84, 25);
            this.btnchoisir.TabIndex = 24;
            this.btnchoisir.Text = "telecharger";
            this.btnchoisir.UseVisualStyleBackColor = false;
            this.btnchoisir.Click += new System.EventHandler(this.btnchoisir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "image";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(116, 76);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 43);
            this.txtDesc.TabIndex = 22;
            this.txtDesc.Text = "";
            // 
            // imagecat
            // 
            this.imagecat.Image = ((System.Drawing.Image)(resources.GetObject("imagecat.Image")));
            this.imagecat.Location = new System.Drawing.Point(116, 168);
            this.imagecat.Name = "imagecat";
            this.imagecat.Size = new System.Drawing.Size(133, 78);
            this.imagecat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagecat.TabIndex = 21;
            this.imagecat.TabStop = false;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(116, 50);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(100, 20);
            this.txtnom.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "description";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "nom";
            // 
            // AjouterCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(263, 369);
            this.Controls.Add(this.btnajouterCat);
            this.Controls.Add(this.btnchoisir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.imagecat);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "AjouterCategorie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjouterCategorie";
            this.Load += new System.EventHandler(this.AjouterCategorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagecat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnajouterCat;
        private System.Windows.Forms.Button btnchoisir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.PictureBox imagecat;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}