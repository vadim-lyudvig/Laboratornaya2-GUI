
namespace Labaratornaya.GUI
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.a = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Результат = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(26, 29);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(102, 23);
            this.a.TabIndex = 0;
            this.a.KeyDown += new System.Windows.Forms.KeyEventHandler(this.a_KeyDown);
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(169, 29);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(114, 23);
            this.b.TabIndex = 1;
            this.b.KeyDown += new System.Windows.Forms.KeyEventHandler(this.b_KeyDown);
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(309, 29);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(114, 23);
            this.c.TabIndex = 2;
            this.c.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сторона А";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(193, 11);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(64, 15);
            this.label.TabIndex = 4;
            this.label.Text = "Сторона B\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сторона C\r\n";
            // 
            // Результат
            // 
            this.Результат.Location = new System.Drawing.Point(101, 75);
            this.Результат.Name = "Результат";
            this.Результат.Size = new System.Drawing.Size(256, 23);
            this.Результат.TabIndex = 6;
            this.Результат.Text = "Результат";
            this.Результат.UseVisualStyleBackColor = true;
            this.Результат.Click += new System.EventHandler(this.button1_Click);
            this.Результат.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Результат_KeyDown);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 110);
            this.Controls.Add(this.Результат);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Name = "Form2";
            this.Text = "Работа с треугольником";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Результат;
    }
}

