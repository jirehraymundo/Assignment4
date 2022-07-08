namespace Assignment4
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
            this.Btn1_Output = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn2_File = new System.Windows.Forms.Button();
            this.Btn3_Folder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn1_Output
            // 
            this.Btn1_Output.Location = new System.Drawing.Point(33, 41);
            this.Btn1_Output.Name = "Btn1_Output";
            this.Btn1_Output.Size = new System.Drawing.Size(75, 23);
            this.Btn1_Output.TabIndex = 0;
            this.Btn1_Output.Text = "Output";
            this.Btn1_Output.UseVisualStyleBackColor = true;
           
            //this.Btn1_Output.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 23);
            this.textBox1.TabIndex = 1;
            // 
            // Btn2_File
            // 
            this.Btn2_File.Location = new System.Drawing.Point(110, 123);
            this.Btn2_File.Name = "Btn2_File";
            this.Btn2_File.Size = new System.Drawing.Size(107, 45);
            this.Btn2_File.TabIndex = 2;
            this.Btn2_File.Text = "File";
            this.Btn2_File.UseVisualStyleBackColor = true;
            this.Btn2_File.Click += new System.EventHandler(this.Btn2_File_Click);
            // 
            // Btn3_Folder
            // 
            this.Btn3_Folder.Location = new System.Drawing.Point(376, 123);
            this.Btn3_Folder.Name = "Btn3_Folder";
            this.Btn3_Folder.Size = new System.Drawing.Size(107, 45);
            this.Btn3_Folder.TabIndex = 3;
            this.Btn3_Folder.Text = "Folder";
            this.Btn3_Folder.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 308);
            this.Controls.Add(this.Btn3_Folder);
            this.Controls.Add(this.Btn2_File);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn1_Output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn1_Output;
        private TextBox textBox1;
        private Button Btn2_File;
        private Button Btn3_Folder;
    }
}