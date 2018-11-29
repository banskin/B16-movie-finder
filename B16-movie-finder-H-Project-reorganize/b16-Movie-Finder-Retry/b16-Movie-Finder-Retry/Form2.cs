using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movieFinder
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}
		static Form1 f1 = new Form1();
		public void button2_Click(object sender, EventArgs e)
		{
			this.Hide(); // This is bad
			f1.Show();
		}

		public void listBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		public void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		public void button1_Click(object sender, EventArgs e)
		{
			string wishlistEntry = textBox1.Text;

			listBox2.Items.Add(wishlistEntry);
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}
	}
}
