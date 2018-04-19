namespace listViewDemo
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
            this.demolistView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // demolistView
            // 
            this.demolistView.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demolistView.Location = new System.Drawing.Point(31, 73);
            this.demolistView.MultiSelect = false;
            this.demolistView.Name = "demolistView";
            this.demolistView.Size = new System.Drawing.Size(127, 98);
            this.demolistView.TabIndex = 0;
            this.demolistView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "List View Demo";
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(12, 264);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(115, 23);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "Print Selection";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // quit
            // 
            this.quit.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.Location = new System.Drawing.Point(133, 264);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 23);
            this.quit.TabIndex = 3;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(12, 188);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(177, 73);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "Output";
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(83, 293);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 5;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 326);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.demolistView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView demolistView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button clear;
    }
}

