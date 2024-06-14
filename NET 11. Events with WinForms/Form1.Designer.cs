namespace NET_11._Events_with_WinForms
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
            myButton = new Button();
            myButton1 = new Button();
            SuspendLayout();
            // 
            // myButton
            // 
            myButton.Location = new Point(209, 62);
            myButton.Name = "myButton";
            myButton.Size = new Size(260, 81);
            myButton.TabIndex = 0;
            myButton.Text = "Click Me";
            myButton.UseVisualStyleBackColor = true;
            myButton.Click += myButton_Click;
            myButton1.Click += myButton_Click;
            //myButton.Click += SomeOtherMethod;
            // 
            // myButton1
            // 
            myButton1.Location = new Point(209, 208);
            myButton1.Name = "myButton1";
            myButton1.Size = new Size(260, 81);
            myButton1.TabIndex = 0;
            myButton1.Text = "Click Me other";
            myButton1.UseVisualStyleBackColor = true;
            myButton1.Click += SomeOtherMethod;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(myButton1);
            Controls.Add(myButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button myButton;
        private Button myButton1;
    }
}
