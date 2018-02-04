namespace SummatorDesktop
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
            this.numA = new System.Windows.Forms.TextBox();
            this.numB = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numA
            // 
            this.numA.Location = new System.Drawing.Point(54, 61);
            this.numA.Name = "numA";
            this.numA.Size = new System.Drawing.Size(100, 22);
            this.numA.TabIndex = 0;
            // 
            // numB
            // 
            this.numB.Location = new System.Drawing.Point(196, 73);
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(100, 22);
            this.numB.TabIndex = 1;
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(396, 61);
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            this.sum.Size = new System.Drawing.Size(100, 22);
            this.sum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(80, 164);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(462, 77);
            this.calculate.TabIndex = 5;
            this.calculate.Text = "Сумирай";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 253);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.numB);
            this.Controls.Add(this.numA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numA;
        private System.Windows.Forms.TextBox numB;
        private System.Windows.Forms.TextBox sum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculate;
    }
}

