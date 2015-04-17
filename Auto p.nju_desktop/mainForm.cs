using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_p.nju_desktop
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void mainForm_Load(object sender, EventArgs e)
		{
			checkBoxAutoLogin.Checked = Properties.Settings.Default.autoLogin;
			checkBoxReconnectOnFail.Checked = Properties.Settings.Default.autoReconnect;
			textBoxUsername.Text = Properties.Settings.Default.username;
			textBoxPassword.Text = Properties.Settings.Default.password;

			if(Properties.Settings.Default.autoLogin)
			{
				ReturnMessage ret = null;
				do
				{
					ret = AutoConnect.connect(textBoxUsername.Text, textBoxPassword.Text);
				} while (ret==null);
				GlobalFunction.showInfo(ret, this);
				this.WindowState = FormWindowState.Minimized;
			}
			if (Properties.Settings.Default.autoReconnect)
				timer.Enabled = true;
		}

		private void saveUsernameAndPassword()
		{
			Properties.Settings.Default.username = textBoxUsername.Text;
			Properties.Settings.Default.password = textBoxPassword.Text;
			Properties.Settings.Default.Save();
		}

		private void clearUsernameAndPassword()
		{
			Properties.Settings.Default.username = "";
			Properties.Settings.Default.password = "";
			Properties.Settings.Default.Save();
		}

		private void saveOptions()
		{
			Properties.Settings.Default.autoLogin = checkBoxAutoLogin.Checked;
			Properties.Settings.Default.autoReconnect = checkBoxReconnectOnFail.Checked;
			Properties.Settings.Default.Save();
		}

		private void mainForm_SizeChanged(object sender, EventArgs e)
		{
			if(this.WindowState==FormWindowState.Minimized)
			{
				this.Hide();
				notifyIcon.Visible = true;
			}
		}

		private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
		{
			this.Show();
			this.WindowState = FormWindowState.Normal;
			notifyIcon.Visible = false;
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			saveOptions();
			if (checkBoxAutoLogin.Checked)
				saveUsernameAndPassword();
			else
				clearUsernameAndPassword();
			ReturnMessage ret = null;
			do
			{
				ret = AutoConnect.connect(textBoxUsername.Text, textBoxPassword.Text);
			} while (ret == null);
			GlobalFunction.showInfo(ret, this);
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			ReturnMessage ret = AutoConnect.connect(Properties.Settings.Default.username, Properties.Settings.Default.password);
			GlobalFunction.showInfo(ret, this);
		}
	}
}
