namespace _15_Desktop_Catch_the_Button_App
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
            this.catchMeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // catchMeButton
            // 
            this.catchMeButton.Location = new System.Drawing.Point(359, 188);
            this.catchMeButton.Name = "catchMeButton";
            this.catchMeButton.Size = new System.Drawing.Size(109, 73);
            this.catchMeButton.TabIndex = 0;
            this.catchMeButton.Text = "Catch Me!";
            this.catchMeButton.UseVisualStyleBackColor = true;
            this.catchMeButton.Click += new System.EventHandler(this.catchMeButton_Click);
            this.catchMeButton.MouseEnter += new System.EventHandler(this.catchMeButton_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 467);
            this.Controls.Add(this.catchMeButton);
            this.Name = "Form1";
            this.Text = "Catch the Button";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button catchMeButton;
    }
}

