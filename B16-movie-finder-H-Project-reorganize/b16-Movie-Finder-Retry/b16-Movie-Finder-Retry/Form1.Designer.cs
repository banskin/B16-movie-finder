﻿namespace movieFinder
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
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(428, 50);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(106, 46);
			this.button1.TabIndex = 0;
			this.button1.Text = "Search";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(32, 64);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(354, 32);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(572, 119);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(267, 368);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(32, 119);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(502, 368);
			this.listBox1.TabIndex = 4;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(32, 12);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "Lists";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(651, 50);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(106, 46);
			this.button4.TabIndex = 7;
			this.button4.Text = "Add to wishlist";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(862, 508);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}

