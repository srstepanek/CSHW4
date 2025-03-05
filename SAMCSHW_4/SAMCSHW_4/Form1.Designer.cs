namespace SAMCSHW_4
{
    partial class Form1
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
            this.PictureBoxRaw = new System.Windows.Forms.PictureBox();
            this.PictureBoxLaneLines = new System.Windows.Forms.PictureBox();
            this.PictureBoxRedLine = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.DirectionLabel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLaneLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRedLine)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxRaw
            // 
            this.PictureBoxRaw.Location = new System.Drawing.Point(54, 123);
            this.PictureBoxRaw.Name = "PictureBoxRaw";
            this.PictureBoxRaw.Size = new System.Drawing.Size(591, 430);
            this.PictureBoxRaw.TabIndex = 0;
            this.PictureBoxRaw.TabStop = false;
            // 
            // PictureBoxLaneLines
            // 
            this.PictureBoxLaneLines.Location = new System.Drawing.Point(794, 123);
            this.PictureBoxLaneLines.Name = "PictureBoxLaneLines";
            this.PictureBoxLaneLines.Size = new System.Drawing.Size(602, 430);
            this.PictureBoxLaneLines.TabIndex = 1;
            this.PictureBoxLaneLines.TabStop = false;
            // 
            // PictureBoxRedLine
            // 
            this.PictureBoxRedLine.Location = new System.Drawing.Point(1559, 123);
            this.PictureBoxRedLine.Name = "PictureBoxRedLine";
            this.PictureBoxRedLine.Size = new System.Drawing.Size(558, 430);
            this.PictureBoxRedLine.TabIndex = 2;
            this.PictureBoxRedLine.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 38);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1051, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 38);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1794, 79);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 38);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // DirectionLabel
            // 
            this.DirectionLabel.Location = new System.Drawing.Point(772, 723);
            this.DirectionLabel.Name = "DirectionLabel";
            this.DirectionLabel.Size = new System.Drawing.Size(653, 38);
            this.DirectionLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2329, 888);
            this.Controls.Add(this.DirectionLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PictureBoxRedLine);
            this.Controls.Add(this.PictureBoxLaneLines);
            this.Controls.Add(this.PictureBoxRaw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLaneLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRedLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxRaw;
        private System.Windows.Forms.PictureBox PictureBoxLaneLines;
        private System.Windows.Forms.PictureBox PictureBoxRedLine;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox DirectionLabel;
    }
}

