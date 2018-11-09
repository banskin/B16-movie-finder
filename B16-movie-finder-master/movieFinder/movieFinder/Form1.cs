using System;
using System.Net;
using System.IO;
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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string UrlText = textBox1.Text.Replace(" ", "+");
			

			string URL = "http://www.omdbapi.com/?t=" + UrlText + "&apikey=3c1d34eb";

			WebRequest request = WebRequest.Create(URL);
			WebResponse response = request.GetResponse();
			string result = new StreamReader(response.GetResponseStream()).ReadToEnd();
			List<string> TagIds = result.Split(',').ToList<string>();
			foreach(string s in TagIds)
			{
				listBox1.Items.Add(s);
			}


			//infoArea.Text = result;

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form2 f = new Form2(); // This is bad
			f.Show();
		}
	}
}
