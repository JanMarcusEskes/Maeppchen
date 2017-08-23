namespace Mäppchen
{
    partial class MäppchenInhalt
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
            this.btnRemoveStift = new System.Windows.Forms.Button();
            this.btnAddStift = new System.Windows.Forms.Button();
            this.btnÖffnenSchließen = new System.Windows.Forms.Button();
            this.btnAnmalen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFarbe = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstvStifte = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemoveStift
            // 
            this.btnRemoveStift.Location = new System.Drawing.Point(135, 66);
            this.btnRemoveStift.Name = "btnRemoveStift";
            this.btnRemoveStift.Size = new System.Drawing.Size(98, 23);
            this.btnRemoveStift.TabIndex = 21;
            this.btnRemoveStift.Text = "Stift rausnehmen";
            this.btnRemoveStift.UseVisualStyleBackColor = true;
            // 
            // btnAddStift
            // 
            this.btnAddStift.Location = new System.Drawing.Point(31, 66);
            this.btnAddStift.Name = "btnAddStift";
            this.btnAddStift.Size = new System.Drawing.Size(98, 23);
            this.btnAddStift.TabIndex = 20;
            this.btnAddStift.Text = "Stift reinlegen";
            this.btnAddStift.UseVisualStyleBackColor = true;
            this.btnAddStift.Click += new System.EventHandler(this.btnAddStift_Click);
            // 
            // btnÖffnenSchließen
            // 
            this.btnÖffnenSchließen.Location = new System.Drawing.Point(158, 37);
            this.btnÖffnenSchließen.Name = "btnÖffnenSchließen";
            this.btnÖffnenSchließen.Size = new System.Drawing.Size(75, 23);
            this.btnÖffnenSchließen.TabIndex = 19;
            this.btnÖffnenSchließen.Text = "Öffnen";
            this.btnÖffnenSchließen.UseVisualStyleBackColor = true;
            this.btnÖffnenSchließen.Click += new System.EventHandler(this.btnÖffnenSchließen_Click);
            // 
            // btnAnmalen
            // 
            this.btnAnmalen.Location = new System.Drawing.Point(158, 8);
            this.btnAnmalen.Name = "btnAnmalen";
            this.btnAnmalen.Size = new System.Drawing.Size(75, 23);
            this.btnAnmalen.TabIndex = 18;
            this.btnAnmalen.Text = "Anmalen";
            this.btnAnmalen.UseVisualStyleBackColor = true;
            this.btnAnmalen.Click += new System.EventHandler(this.btnAnmalen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Farbe";
            // 
            // txtFarbe
            // 
            this.txtFarbe.Location = new System.Drawing.Point(52, 10);
            this.txtFarbe.Name = "txtFarbe";
            this.txtFarbe.Size = new System.Drawing.Size(100, 20);
            this.txtFarbe.TabIndex = 16;
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
            this.splitContainer1.Panel1.Controls.Add(this.btnRemoveStift);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddStift);
            this.splitContainer1.Panel1.Controls.Add(this.txtFarbe);
            this.splitContainer1.Panel1.Controls.Add(this.btnÖffnenSchließen);
            this.splitContainer1.Panel1.Controls.Add(this.btnAnmalen);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstvStifte);
            this.splitContainer1.Size = new System.Drawing.Size(395, 369);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 22;
            // 
            // lstvStifte
            // 
            this.lstvStifte.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstvStifte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvStifte.Location = new System.Drawing.Point(0, 0);
            this.lstvStifte.Name = "lstvStifte";
            this.lstvStifte.Size = new System.Drawing.Size(395, 265);
            this.lstvStifte.TabIndex = 0;
            this.lstvStifte.UseCompatibleStateImageBehavior = false;
            this.lstvStifte.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Typ";
            this.columnHeader1.Width = 76;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Material";
            this.columnHeader2.Width = 78;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Farbe";
            this.columnHeader3.Width = 74;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Zustand";
            this.columnHeader4.Width = 85;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Länge";
            this.columnHeader5.Width = 73;
            // 
            // MäppchenInhalt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 369);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MäppchenInhalt";
            this.Text = "MäppchenInhalt";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveStift;
        private System.Windows.Forms.Button btnAddStift;
        private System.Windows.Forms.Button btnÖffnenSchließen;
        private System.Windows.Forms.Button btnAnmalen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFarbe;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lstvStifte;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}