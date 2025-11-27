namespace CustomControl
{
    partial class Form1
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
            customButton1 = new CustomButton();
            SuspendLayout();
            // 
            // customButton1
            // 
            customButton1.BackColor = SystemColors.ActiveCaption;
            customButton1.Icon = Properties.Resources.Screenshot_2025_10_21_005206;
            customButton1.Location = new Point(314, 134);
            customButton1.Name = "customButton1";
            customButton1.NativeCheck = true;
            customButton1.Size = new Size(270, 187);
            customButton1.TabIndex = 0;
            customButton1.Text = "customButton1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(customButton1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private CustomButton customButton1;
    }
}
