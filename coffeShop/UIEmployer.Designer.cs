namespace coffeShop
{
    partial class UIEmployer
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
            this.lblClose = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flpanelCat = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flPanelProd = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnumtick = new System.Windows.Forms.TextBox();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomproduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnprods = new System.Windows.Forms.Button();
            this.btnajcat = new System.Windows.Forms.Button();
            this.btnajpro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtmtdonne = new System.Windows.Forms.TextBox();
            this.txtmtretourne = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirme = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(1162, 4);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(27, 25);
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.Location = new System.Drawing.Point(1116, -21);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(37, 39);
            this.lblRed.TabIndex = 1;
            this.lblRed.Text = "_";
            this.lblRed.Click += new System.EventHandler(this.lblRed_Click);
            this.lblRed.MouseEnter += new System.EventHandler(this.lblRed_MouseEnter);
            this.lblRed.MouseLeave += new System.EventHandler(this.lblRed_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flpanelCat);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 282);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categories";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // flpanelCat
            // 
            this.flpanelCat.AutoScroll = true;
            this.flpanelCat.Location = new System.Drawing.Point(6, 19);
            this.flpanelCat.Name = "flpanelCat";
            this.flpanelCat.Size = new System.Drawing.Size(636, 257);
            this.flpanelCat.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flPanelProd);
            this.groupBox2.Location = new System.Drawing.Point(12, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 290);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produits";
            // 
            // flPanelProd
            // 
            this.flPanelProd.AutoScroll = true;
            this.flPanelProd.Location = new System.Drawing.Point(7, 13);
            this.flPanelProd.Name = "flPanelProd";
            this.flPanelProd.Size = new System.Drawing.Size(635, 267);
            this.flPanelProd.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtnumtick);
            this.groupBox3.Controls.Add(this.dgvProd);
            this.groupBox3.Location = new System.Drawing.Point(668, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(512, 377);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ticket";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "id ticket";
            // 
            // txtnumtick
            // 
            this.txtnumtick.Enabled = false;
            this.txtnumtick.Location = new System.Drawing.Point(56, 34);
            this.txtnumtick.Name = "txtnumtick";
            this.txtnumtick.Size = new System.Drawing.Size(100, 20);
            this.txtnumtick.TabIndex = 1;
            this.txtnumtick.Text = "0";
            this.txtnumtick.TextChanged += new System.EventHandler(this.txtnumtick_TextChanged);
            // 
            // dgvProd
            // 
            this.dgvProd.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nomproduit,
            this.prix,
            this.qte,
            this.totalProduit,
            this.delete});
            this.dgvProd.Location = new System.Drawing.Point(6, 70);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.Size = new System.Drawing.Size(500, 281);
            this.dgvProd.TabIndex = 0;
            this.dgvProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProd_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // Nomproduit
            // 
            this.Nomproduit.HeaderText = " Nom produit";
            this.Nomproduit.Name = "Nomproduit";
            // 
            // prix
            // 
            this.prix.HeaderText = "prix";
            this.prix.Name = "prix";
            this.prix.Width = 50;
            // 
            // qte
            // 
            this.qte.HeaderText = "qte";
            this.qte.Name = "qte";
            this.qte.Width = 30;
            // 
            // totalProduit
            // 
            this.totalProduit.HeaderText = "totalProduit";
            this.totalProduit.Name = "totalProduit";
            this.totalProduit.Width = 80;
            // 
            // delete
            // 
            this.delete.HeaderText = "delete";
            this.delete.Name = "delete";
            this.delete.Width = 80;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblRed);
            this.panel1.Controls.Add(this.btnAct);
            this.panel1.Controls.Add(this.btnTransaction);
            this.panel1.Controls.Add(this.btnprods);
            this.panel1.Controls.Add(this.btnajcat);
            this.panel1.Controls.Add(this.btnajpro);
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 38);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1006, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(481, 7);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(62, 23);
            this.btnAct.TabIndex = 5;
            this.btnAct.Text = "actualiser";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.BurlyWood;
            this.btnTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTransaction.Location = new System.Drawing.Point(348, 7);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(116, 24);
            this.btnTransaction.TabIndex = 4;
            this.btnTransaction.Text = "voir les transactions";
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnprods
            // 
            this.btnprods.BackColor = System.Drawing.Color.BurlyWood;
            this.btnprods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprods.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprods.Location = new System.Drawing.Point(232, 7);
            this.btnprods.Name = "btnprods";
            this.btnprods.Size = new System.Drawing.Size(95, 24);
            this.btnprods.TabIndex = 3;
            this.btnprods.Text = "voir les produits";
            this.btnprods.UseVisualStyleBackColor = false;
            this.btnprods.Click += new System.EventHandler(this.btnprods_Click);
            // 
            // btnajcat
            // 
            this.btnajcat.BackColor = System.Drawing.Color.BurlyWood;
            this.btnajcat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnajcat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnajcat.Location = new System.Drawing.Point(121, 7);
            this.btnajcat.Name = "btnajcat";
            this.btnajcat.Size = new System.Drawing.Size(95, 24);
            this.btnajcat.TabIndex = 2;
            this.btnajcat.Text = "ajouter categorie";
            this.btnajcat.UseVisualStyleBackColor = false;
            this.btnajcat.Click += new System.EventHandler(this.btnajcat_Click);
            // 
            // btnajpro
            // 
            this.btnajpro.BackColor = System.Drawing.Color.BurlyWood;
            this.btnajpro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnajpro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnajpro.Location = new System.Drawing.Point(9, 7);
            this.btnajpro.Name = "btnajpro";
            this.btnajpro.Size = new System.Drawing.Size(95, 24);
            this.btnajpro.TabIndex = 1;
            this.btnajpro.Text = "ajouter produit";
            this.btnajpro.UseVisualStyleBackColor = false;
            this.btnajpro.Click += new System.EventHandler(this.btnajpro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(979, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Totale";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(1049, 443);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // txtmtdonne
            // 
            this.txtmtdonne.Location = new System.Drawing.Point(1049, 510);
            this.txtmtdonne.Name = "txtmtdonne";
            this.txtmtdonne.Size = new System.Drawing.Size(100, 20);
            this.txtmtdonne.TabIndex = 8;
            this.txtmtdonne.TextChanged += new System.EventHandler(this.txtmtdonne_TextChanged);
            // 
            // txtmtretourne
            // 
            this.txtmtretourne.Location = new System.Drawing.Point(1049, 579);
            this.txtmtretourne.Name = "txtmtretourne";
            this.txtmtretourne.Size = new System.Drawing.Size(100, 20);
            this.txtmtretourne.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(938, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "montant donné";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(920, 582);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "montant a retourne";
            // 
            // btnConfirme
            // 
            this.btnConfirme.BackColor = System.Drawing.Color.BurlyWood;
            this.btnConfirme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirme.Location = new System.Drawing.Point(1049, 624);
            this.btnConfirme.Name = "btnConfirme";
            this.btnConfirme.Size = new System.Drawing.Size(86, 29);
            this.btnConfirme.TabIndex = 12;
            this.btnConfirme.Text = "Confirmer";
            this.btnConfirme.UseVisualStyleBackColor = false;
            this.btnConfirme.Click += new System.EventHandler(this.btnConfirme_Click);
            // 
            // UIEmployer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1199, 667);
            this.Controls.Add(this.btnConfirme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmtretourne);
            this.Controls.Add(this.txtmtdonne);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UIEmployer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UIEmployer";
            this.Load += new System.EventHandler(this.UIEmployer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomproduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn qte;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalProduit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.Button btnajcat;
        private System.Windows.Forms.Button btnajpro;
        private System.Windows.Forms.Button btnprods;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.FlowLayoutPanel flpanelCat;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.FlowLayoutPanel flPanelProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtmtdonne;
        private System.Windows.Forms.TextBox txtmtretourne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirme;
        private System.Windows.Forms.TextBox txtnumtick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}