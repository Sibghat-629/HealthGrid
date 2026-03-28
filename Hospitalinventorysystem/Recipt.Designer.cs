namespace Hospitalinventorysystem
{
    partial class Recipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recipt));
            this.updatebuttons = new System.Windows.Forms.Button();
            this.deletebuttons = new System.Windows.Forms.Button();
            this.resetbuttons = new System.Windows.Forms.Button();
            this.addbuttons = new System.Windows.Forms.Button();
            this.dataGridView10 = new System.Windows.Forms.DataGridView();
            this.results = new System.Windows.Forms.TextBox();
            this.bill = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // updatebuttons
            // 
            this.updatebuttons.BackColor = System.Drawing.Color.Tomato;
            this.updatebuttons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebuttons.Location = new System.Drawing.Point(220, 510);
            this.updatebuttons.Name = "updatebuttons";
            this.updatebuttons.Size = new System.Drawing.Size(116, 48);
            this.updatebuttons.TabIndex = 34;
            this.updatebuttons.Text = "UPDATE";
            this.updatebuttons.UseVisualStyleBackColor = false;
            this.updatebuttons.Click += new System.EventHandler(this.updatebuttons_Click);
            // 
            // deletebuttons
            // 
            this.deletebuttons.BackColor = System.Drawing.Color.MistyRose;
            this.deletebuttons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebuttons.Location = new System.Drawing.Point(402, 510);
            this.deletebuttons.Name = "deletebuttons";
            this.deletebuttons.Size = new System.Drawing.Size(116, 48);
            this.deletebuttons.TabIndex = 33;
            this.deletebuttons.Text = "DELETE";
            this.deletebuttons.UseVisualStyleBackColor = false;
            this.deletebuttons.Click += new System.EventHandler(this.deletebuttons_Click);
            // 
            // resetbuttons
            // 
            this.resetbuttons.BackColor = System.Drawing.Color.LightCoral;
            this.resetbuttons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbuttons.Location = new System.Drawing.Point(606, 510);
            this.resetbuttons.Name = "resetbuttons";
            this.resetbuttons.Size = new System.Drawing.Size(116, 48);
            this.resetbuttons.TabIndex = 32;
            this.resetbuttons.Text = "RESET";
            this.resetbuttons.UseVisualStyleBackColor = false;
            this.resetbuttons.Click += new System.EventHandler(this.resetbuttons_Click);
            // 
            // addbuttons
            // 
            this.addbuttons.BackColor = System.Drawing.SystemColors.Highlight;
            this.addbuttons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbuttons.Location = new System.Drawing.Point(12, 510);
            this.addbuttons.Name = "addbuttons";
            this.addbuttons.Size = new System.Drawing.Size(116, 48);
            this.addbuttons.TabIndex = 31;
            this.addbuttons.Text = "ADD";
            this.addbuttons.UseVisualStyleBackColor = false;
            this.addbuttons.Click += new System.EventHandler(this.addbuttons_Click);
            // 
            // dataGridView10
            // 
            this.dataGridView10.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView10.Location = new System.Drawing.Point(12, 262);
            this.dataGridView10.Name = "dataGridView10";
            this.dataGridView10.Size = new System.Drawing.Size(786, 230);
            this.dataGridView10.TabIndex = 30;
            this.dataGridView10.DoubleClick += new System.EventHandler(this.dataGridView10_DoubleClick);
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(211, 223);
            this.results.Multiline = true;
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(125, 27);
            this.results.TabIndex = 27;
            // 
            // bill
            // 
            this.bill.Location = new System.Drawing.Point(379, 223);
            this.bill.Multiline = true;
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(125, 27);
            this.bill.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Recipt ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Results";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Bill";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "Recipt";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(166, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // rid
            // 
            this.rid.Location = new System.Drawing.Point(31, 223);
            this.rid.Multiline = true;
            this.rid.Name = "rid";
            this.rid.Size = new System.Drawing.Size(125, 27);
            this.rid.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 100);
            this.panel1.TabIndex = 36;
            // 
            // Recipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(810, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rid);
            this.Controls.Add(this.updatebuttons);
            this.Controls.Add(this.deletebuttons);
            this.Controls.Add(this.resetbuttons);
            this.Controls.Add(this.addbuttons);
            this.Controls.Add(this.dataGridView10);
            this.Controls.Add(this.results);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recipt";
            this.Text = "Recipt";
            this.Load += new System.EventHandler(this.Recipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updatebuttons;
        private System.Windows.Forms.Button deletebuttons;
        private System.Windows.Forms.Button resetbuttons;
        private System.Windows.Forms.Button addbuttons;
        private System.Windows.Forms.DataGridView dataGridView10;
        private System.Windows.Forms.TextBox results;
        private System.Windows.Forms.TextBox bill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox rid;
        private System.Windows.Forms.Panel panel1;
    }
}