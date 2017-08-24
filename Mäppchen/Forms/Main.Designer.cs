namespace Mäppchen
{
  partial class Main
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
            this.Material = new System.Windows.Forms.Label();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtForm = new System.Windows.Forms.TextBox();
            this.nudMaxStifte = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnErstelle = new System.Windows.Forms.Button();
            this.lstvMäppchen = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxStifte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Material
            // 
            this.Material.AutoSize = true;
            this.Material.Location = new System.Drawing.Point(12, 14);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(44, 13);
            this.Material.TabIndex = 3;
            this.Material.Text = "Material";
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(120, 11);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(100, 20);
            this.txtMaterial.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Form";
            // 
            // txtForm
            // 
            this.txtForm.Location = new System.Drawing.Point(120, 34);
            this.txtForm.Name = "txtForm";
            this.txtForm.Size = new System.Drawing.Size(100, 20);
            this.txtForm.TabIndex = 5;
            // 
            // nudMaxStifte
            // 
            this.nudMaxStifte.Location = new System.Drawing.Point(120, 63);
            this.nudMaxStifte.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMaxStifte.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxStifte.Name = "nudMaxStifte";
            this.nudMaxStifte.Size = new System.Drawing.Size(100, 20);
            this.nudMaxStifte.TabIndex = 7;
            this.nudMaxStifte.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Maximale Stifte";
            // 
            // btnErstelle
            // 
            this.btnErstelle.Location = new System.Drawing.Point(15, 89);
            this.btnErstelle.Name = "btnErstelle";
            this.btnErstelle.Size = new System.Drawing.Size(205, 23);
            this.btnErstelle.TabIndex = 9;
            this.btnErstelle.Text = "Erstelle Mäppchen";
            this.btnErstelle.UseVisualStyleBackColor = true;
            this.btnErstelle.Click += new System.EventHandler(this.btnErstelle_Click);
            // 
            // lstvMäppchen
            // 
            this.lstvMäppchen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstvMäppchen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvMäppchen.FullRowSelect = true;
            this.lstvMäppchen.Location = new System.Drawing.Point(0, 0);
            this.lstvMäppchen.Name = "lstvMäppchen";
            this.lstvMäppchen.Size = new System.Drawing.Size(492, 290);
            this.lstvMäppchen.TabIndex = 10;
            this.lstvMäppchen.UseCompatibleStateImageBehavior = false;
            this.lstvMäppchen.View = System.Windows.Forms.View.Details;
            this.lstvMäppchen.DoubleClick += new System.EventHandler(this.lstvMäppchen_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type";
            this.columnHeader1.Width = 67;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Farbe";
            this.columnHeader2.Width = 76;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Form";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Offen?";
            this.columnHeader4.Width = 68;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Maximale Stiftzahl";
            this.columnHeader5.Width = 97;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Inhalt (Stifte)";
            this.columnHeader6.Width = 80;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnErstelle);
            this.splitContainer1.Panel1.Controls.Add(this.Material);
            this.splitContainer1.Panel1.Controls.Add(this.nudMaxStifte);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtForm);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaterial);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstvMäppchen);
            this.splitContainer1.Size = new System.Drawing.Size(492, 424);
            this.splitContainer1.SplitterDistance = 130;
            this.splitContainer1.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 424);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Main";
            this.Text = "Mäppchen Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxStifte)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Label Material;
    private System.Windows.Forms.TextBox txtMaterial;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtForm;
    private System.Windows.Forms.NumericUpDown nudMaxStifte;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnErstelle;
        private System.Windows.Forms.ListView lstvMäppchen;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

