﻿namespace ShiftOS.Engine.WindowManager
{
    partial class InfoboxTemplate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.changeSize = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpt1 = new System.Windows.Forms.Button();
            this.btnOpt2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::ShiftOS.Engine.Properties.Resources.Symbolinfo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // changeSize
            // 
            this.changeSize.Interval = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label1.Location = new System.Drawing.Point(105, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // btnOpt1
            // 
            this.btnOpt1.BackColor = System.Drawing.Color.White;
            this.btnOpt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpt1.Location = new System.Drawing.Point(108, 171);
            this.btnOpt1.Name = "btnOpt1";
            this.btnOpt1.Size = new System.Drawing.Size(75, 23);
            this.btnOpt1.TabIndex = 4;
            this.btnOpt1.Text = "button1";
            this.btnOpt1.UseVisualStyleBackColor = false;
            this.btnOpt1.Click += new System.EventHandler(this.btnOpt1_Click);
            // 
            // btnOpt2
            // 
            this.btnOpt2.BackColor = System.Drawing.Color.White;
            this.btnOpt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpt2.Location = new System.Drawing.Point(247, 171);
            this.btnOpt2.Name = "btnOpt2";
            this.btnOpt2.Size = new System.Drawing.Size(75, 23);
            this.btnOpt2.TabIndex = 5;
            this.btnOpt2.Text = "button2";
            this.btnOpt2.UseVisualStyleBackColor = false;
            // 
            // InfoboxTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOpt2);
            this.Controls.Add(this.btnOpt1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.Name = "InfoboxTemplate";
            this.Size = new System.Drawing.Size(438, 210);
            this.Load += new System.EventHandler(this.InfoboxTemplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer changeSize;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnOpt1;
        public System.Windows.Forms.Button btnOpt2;
    }
}
