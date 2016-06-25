using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
			textBoxUsername.Text = Properties.Settings.Default.username;
			textBoxPassword.Text = Properties.Settings.Default.password;
			checkBoxAutoLogin.Checked = Properties.Settings.Default.autoLogin;
			checkBoxReconnectOnFail.Checked = Properties.Settings.Default.autoReconnect;

			OnlineMessage onlineState = OnlineState.getOnlineState();
			if (onlineState.reply_code == OnlineState.OPERATE_SUCCESS && onlineState.reply_msg != null)
				GlobalFunction.showInfo(onlineState, this);

			if (checkBoxAutoLogin.Checked)
			{
				if (!textBoxUsername.Text.Equals("") && !textBoxPassword.Text.Equals(""))
				{
					OnlineMessage ret = null;
					do
					{
						ret = AutoConnect.connect(textBoxUsername.Text, textBoxPassword.Text);
					} while (ret == null || ret.userinfo == null);
					GlobalFunction.showInfo(ret, this);
				}
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
			this.Focus();
			notifyIcon.Visible = false;
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			saveOptions();

			if(textBoxUsername.Text.Equals("")||textBoxPassword.Text.Equals(""))
			{
				MessageBox.Show("用户名和密码不能为空！", "Auto p.nju", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (checkBoxAutoLogin.Checked)
				saveUsernameAndPassword();
			else
				clearUsernameAndPassword();
			OnlineMessage ret = null;
			do
			{
				ret = AutoConnect.connect(textBoxUsername.Text, textBoxPassword.Text);
			} while (ret == null);

			if (ret.reply_code == AutoConnect.INVALID_PASSWORD)
			{
				timer.Enabled = false;
				MessageBox.Show(ret.reply_msg, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
            //else if(ret.reply_code==AutoConnect.PROCESSING)
            //{
            //    timer.Enabled = false;
            //    MessageBox.Show(ret.reply_msg, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
			else
			{
				Thread.Sleep(1000);
				GlobalFunction.showInfo(OnlineState.getOnlineStateStrict(), this);
			}
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			OnlineMessage onlineState = OnlineState.getOnlineState();
			GlobalFunction.showInfo(onlineState, this);

			if (onlineState.reply_code == OnlineState.NO_PORTAL_MESSAGE)//未登录
			{
				OnlineMessage ret=null;
				if (Properties.Settings.Default.username == "" || Properties.Settings.Default.password == "")
					ret = AutoConnect.connect(Properties.Settings.Default.username, Properties.Settings.Default.password);
				else
					ret = AutoConnect.connect(textBoxUsername.Text, textBoxPassword.Text);
				GlobalFunction.showInfo(ret, this);
			}
		}

		private void checkBoxAutoLogin_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.autoLogin = checkBoxAutoLogin.Checked;
			if(checkBoxAutoLogin.Checked)
			{
				saveUsernameAndPassword();
			}
			else
			{
				clearUsernameAndPassword();
			}
		}

		private void checkBoxReconnectOnFail_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.autoReconnect = checkBoxReconnectOnFail.Checked;
			timer.Enabled = checkBoxReconnectOnFail.Checked;
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			saveOptions();
			saveUsernameAndPassword();
		}

		private void MainForm_Resize(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				notifyIcon.Visible = true;
				this.Hide();
			}
		}

		private void stateRefreshTimer_Tick(object sender, EventArgs e)
		{
			OnlineMessage onlineState = OnlineState.getOnlineState();
			GlobalFunction.showInfo(onlineState, this);
		}
	}
}
