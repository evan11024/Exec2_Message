using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Message
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void messageButton_Click(object sender, EventArgs e)
		{
			
			string greet = string.Empty;
			int hour = DateTime.Now.Hour;
			if (hour > 4 && hour < 12)
			{
				greet = "早安";
			}
			else if(hour>=12&&hour<17)
			{
				greet = "午安";
			}
			else
			{
				greet = "晚安";
			}
			messageLabel.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")+"\n\r"+greet;

		}
	}
}
