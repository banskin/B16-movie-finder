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
		bool DBChoice;
		public Form1()
		{
			InitializeComponent();
			this.ActiveControl = textBox1;
		}
		public void button1_Click(object sender, EventArgs e)
		{
			DBChoice = true;
			listBox1.Items.Clear();
			pictureBox1.Image = null;

			string UrlText = textBox1.Text.Replace(" ", "+");

			string URL = "http://www.omdbapi.com/?t=" + UrlText + "&apikey=3c1d34eb";

			WebRequest request = WebRequest.Create(URL);
			WebResponse response = request.GetResponse();
			string result = new StreamReader(response.GetResponseStream()).ReadToEnd();

			string edited_text = result.Replace("\"", "");
			string edited_text2 = edited_text.Replace("{", "");
			string edited_text3 = edited_text.Replace("}", "");



			List<string> TagIds = edited_text2.Split(',').ToList<string>();
			foreach (string s in TagIds)
			{
				listBox1.Items.Add(s);

			}
			int x = -1;
			// Loop through and find each item that matches the search string.

			try
			{
				// Retrieve the item based on the previous index found. Starts with -1 which searches start.
				x = listBox1.FindString("Poster");

				string poster = listBox1.Items[x].ToString();

				poster = poster.Remove(0, 7);
				pictureBox1.Load(poster);
			}
			catch
			{
				listBox1.Items.Add("NO POSTER FOUND");
			}

			//infoArea.Text = result;


		}

		public void button2_Click(object sender, EventArgs e)
		{
			DBChoice = false;
			listBox1.Items.Clear();
			pictureBox1.Image = null;

			string UrlText = textBox1.Text.Replace(" ", "+");

			string URL = "https://api.themoviedb.org/3/search/movie?api_key=66be5bcbbf38f6554ac0af72889c52ae&query=" + UrlText;


			WebRequest request = WebRequest.Create(URL);
			WebResponse response = request.GetResponse();
			string result = new StreamReader(response.GetResponseStream()).ReadToEnd();

			string edited_text = result.Replace("\"", "");
			string edited_text2 = edited_text.Replace("{", "");
			string edited_text3 = edited_text.Replace("}", "");



			List<string> TagIds = edited_text3.Split(',').ToList<string>();

			foreach (string s in TagIds)
			{
				listBox1.Items.Add(s);

			}
				int x = -1;
			// Loop through and find each item that matches the search string.

			try
			{
				// Retrieve the item based on the previous index found. Starts with -1 which searches start.
				x = listBox1.FindString("Poster");

				string poster = listBox1.Items[x].ToString();

				poster = poster.Remove(0, 7);
				pictureBox1.Load(poster);
			}
			catch
			{
				listBox1.Items.Add("NO POSTER FOUND");
			}
		}


		static Form2 f2 = new Form2();
		public void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			
			f2.Show();
		}

		private void button4_Click(object sender, EventArgs e) //Add to wishlist
		{
			int x = -1;

			x = listBox1.FindString("Title");

			string poster = listBox1.Items[x].ToString();

			poster = poster.Remove(0, 6);
			f2.listBox2.Items.Add(poster);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
		public void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			// Determine whether the key entered is the F1 key. If it is, display Help.
			if (e.KeyCode == Keys.Enter)
			{
				if (DBChoice == true)
					button1.PerformClick();
				else if (DBChoice == false)
					button2.PerformClick();
			}

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

	
	}
}
