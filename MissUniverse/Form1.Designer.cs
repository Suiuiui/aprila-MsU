namespace MissUniverse
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
            this.lBox1 = new System.Windows.Forms.ListBox();
            this.lBox2 = new System.Windows.Forms.ListBox();
            this.lBox3 = new System.Windows.Forms.ListBox();
            this.lBox4 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bPrint1 = new System.Windows.Forms.Button();
            this.bPrint2 = new System.Windows.Forms.Button();
            this.bPrint3 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.nBtn1 = new System.Windows.Forms.Button();
            this.nBtn2 = new System.Windows.Forms.Button();
            this.nBtn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBox1
            // 
            this.lBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.lBox1.FormattingEnabled = true;
            this.lBox1.Location = new System.Drawing.Point(23, 51);
            this.lBox1.Name = "lBox1";
            this.lBox1.Size = new System.Drawing.Size(134, 342);
            this.lBox1.TabIndex = 0;
            this.lBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lBox1_MouseDoubleClick);
            // 
            // lBox2
            // 
            this.lBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.lBox2.FormattingEnabled = true;
            this.lBox2.Location = new System.Drawing.Point(217, 116);
            this.lBox2.Name = "lBox2";
            this.lBox2.Size = new System.Drawing.Size(134, 186);
            this.lBox2.TabIndex = 1;
            this.lBox2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lBox2_MouseDoubleClick);
            // 
            // lBox3
            // 
            this.lBox3.BackColor = System.Drawing.Color.PeachPuff;
            this.lBox3.FormattingEnabled = true;
            this.lBox3.Location = new System.Drawing.Point(428, 155);
            this.lBox3.Name = "lBox3";
            this.lBox3.Size = new System.Drawing.Size(134, 108);
            this.lBox3.TabIndex = 2;
            this.lBox3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lBox3_MouseDoubleClick);
            // 
            // lBox4
            // 
            this.lBox4.BackColor = System.Drawing.Color.PeachPuff;
            this.lBox4.FormattingEnabled = true;
            this.lBox4.Location = new System.Drawing.Point(625, 168);
            this.lBox4.Name = "lBox4";
            this.lBox4.Size = new System.Drawing.Size(134, 69);
            this.lBox4.TabIndex = 3;
            this.lBox4.SelectedIndexChanged += new System.EventHandler(this.lBox4_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Top 20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OldLace;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Top 10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OldLace;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Top 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.OldLace;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(625, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Miss Universe";
            // 
            // bPrint1
            // 
            this.bPrint1.BackColor = System.Drawing.Color.OrangeRed;
            this.bPrint1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrint1.Location = new System.Drawing.Point(249, 326);
            this.bPrint1.Name = "bPrint1";
            this.bPrint1.Size = new System.Drawing.Size(75, 23);
            this.bPrint1.TabIndex = 8;
            this.bPrint1.Text = "Display";
            this.bPrint1.UseVisualStyleBackColor = false;
            this.bPrint1.Click += new System.EventHandler(this.bPrint1_Click);
            // 
            // bPrint2
            // 
            this.bPrint2.BackColor = System.Drawing.Color.OrangeRed;
            this.bPrint2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrint2.Location = new System.Drawing.Point(457, 279);
            this.bPrint2.Name = "bPrint2";
            this.bPrint2.Size = new System.Drawing.Size(75, 23);
            this.bPrint2.TabIndex = 9;
            this.bPrint2.Text = "Display";
            this.bPrint2.UseVisualStyleBackColor = false;
            this.bPrint2.Click += new System.EventHandler(this.bPrint2_Click);
            // 
            // bPrint3
            // 
            this.bPrint3.BackColor = System.Drawing.Color.OrangeRed;
            this.bPrint3.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrint3.Location = new System.Drawing.Point(658, 255);
            this.bPrint3.Name = "bPrint3";
            this.bPrint3.Size = new System.Drawing.Size(75, 23);
            this.bPrint3.TabIndex = 10;
            this.bPrint3.Text = "Display";
            this.bPrint3.UseVisualStyleBackColor = false;
            this.bPrint3.Click += new System.EventHandler(this.bPrint3_Click);
            // 
            // nBtn1
            // 
            this.nBtn1.BackColor = System.Drawing.Color.MediumPurple;
            this.nBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nBtn1.Location = new System.Drawing.Point(175, 181);
            this.nBtn1.Name = "nBtn1";
            this.nBtn1.Size = new System.Drawing.Size(24, 44);
            this.nBtn1.TabIndex = 11;
            this.nBtn1.Text = ">";
            this.nBtn1.UseVisualStyleBackColor = false;
            this.nBtn1.Click += new System.EventHandler(this.nBtn1_Click);
            // 
            // nBtn2
            // 
            this.nBtn2.BackColor = System.Drawing.Color.MediumPurple;
            this.nBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nBtn2.Location = new System.Drawing.Point(378, 181);
            this.nBtn2.Name = "nBtn2";
            this.nBtn2.Size = new System.Drawing.Size(24, 44);
            this.nBtn2.TabIndex = 12;
            this.nBtn2.Text = ">";
            this.nBtn2.UseVisualStyleBackColor = false;
            this.nBtn2.Click += new System.EventHandler(this.nBtn2_Click);
            // 
            // nBtn3
            // 
            this.nBtn3.BackColor = System.Drawing.Color.MediumPurple;
            this.nBtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nBtn3.Location = new System.Drawing.Point(579, 181);
            this.nBtn3.Name = "nBtn3";
            this.nBtn3.Size = new System.Drawing.Size(24, 44);
            this.nBtn3.TabIndex = 13;
            this.nBtn3.Text = ">";
            this.nBtn3.UseVisualStyleBackColor = false;
            this.nBtn3.Click += new System.EventHandler(this.nBtn3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nBtn3);
            this.Controls.Add(this.nBtn2);
            this.Controls.Add(this.nBtn1);
            this.Controls.Add(this.bPrint3);
            this.Controls.Add(this.bPrint2);
            this.Controls.Add(this.bPrint1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lBox4);
            this.Controls.Add(this.lBox3);
            this.Controls.Add(this.lBox2);
            this.Controls.Add(this.lBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBox1;
        private System.Windows.Forms.ListBox lBox2;
        private System.Windows.Forms.ListBox lBox3;
        private System.Windows.Forms.ListBox lBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bPrint1;
        private System.Windows.Forms.Button bPrint2;
        private System.Windows.Forms.Button bPrint3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button nBtn1;
        private System.Windows.Forms.Button nBtn2;
        private System.Windows.Forms.Button nBtn3;
    }
}

