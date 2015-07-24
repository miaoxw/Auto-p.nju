namespace Auto_p.nju_desktop
{
	partial class MainForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.labelUsername = new System.Windows.Forms.Label();
			this.labelPassword = new System.Windows.Forms.Label();
			this.textBoxUsername = new System.Windows.Forms.TextBox();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.checkBoxAutoLogin = new System.Windows.Forms.CheckBox();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.checkBoxReconnectOnFail = new System.Windows.Forms.CheckBox();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.groupBox = new System.Windows.Forms.GroupBox();
			this.labelBalanceValue = new System.Windows.Forms.Label();
			this.labelLoginTimeValue = new System.Windows.Forms.Label();
			this.labelAeraValue = new System.Windows.Forms.Label();
			this.labelIPValue = new System.Windows.Forms.Label();
			this.labelNameValue = new System.Windows.Forms.Label();
			this.labelUsernameValue = new System.Windows.Forms.Label();
			this.labelPayAmount = new System.Windows.Forms.Label();
			this.labelAera = new System.Windows.Forms.Label();
			this.labelLoginTime = new System.Windows.Forms.Label();
			this.labelIP = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.labelUsername2 = new System.Windows.Forms.Label();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.groupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelUsername
			// 
			this.labelUsername.AutoSize = true;
			this.labelUsername.Location = new System.Drawing.Point(20, 35);
			this.labelUsername.Name = "labelUsername";
			this.labelUsername.Size = new System.Drawing.Size(53, 12);
			this.labelUsername.TabIndex = 0;
			this.labelUsername.Text = "用户名：";
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Location = new System.Drawing.Point(32, 68);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(41, 12);
			this.labelPassword.TabIndex = 1;
			this.labelPassword.Text = "密码：";
			// 
			// textBoxUsername
			// 
			this.textBoxUsername.Location = new System.Drawing.Point(79, 32);
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.Size = new System.Drawing.Size(147, 21);
			this.textBoxUsername.TabIndex = 2;
			this.textBoxUsername.WordWrap = false;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(79, 65);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(147, 21);
			this.textBoxPassword.TabIndex = 3;
			this.textBoxPassword.WordWrap = false;
			// 
			// checkBoxAutoLogin
			// 
			this.checkBoxAutoLogin.AutoSize = true;
			this.checkBoxAutoLogin.Location = new System.Drawing.Point(22, 103);
			this.checkBoxAutoLogin.Name = "checkBoxAutoLogin";
			this.checkBoxAutoLogin.Size = new System.Drawing.Size(144, 16);
			this.checkBoxAutoLogin.TabIndex = 4;
			this.checkBoxAutoLogin.Text = "以后自动登录并最小化";
			this.checkBoxAutoLogin.UseVisualStyleBackColor = true;
			this.checkBoxAutoLogin.CheckedChanged += new System.EventHandler(this.checkBoxAutoLogin_CheckedChanged);
			// 
			// buttonLogin
			// 
			this.buttonLogin.Location = new System.Drawing.Point(130, 146);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(75, 23);
			this.buttonLogin.TabIndex = 5;
			this.buttonLogin.Text = "登录";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// checkBoxReconnectOnFail
			// 
			this.checkBoxReconnectOnFail.AutoSize = true;
			this.checkBoxReconnectOnFail.Location = new System.Drawing.Point(172, 103);
			this.checkBoxReconnectOnFail.Name = "checkBoxReconnectOnFail";
			this.checkBoxReconnectOnFail.Size = new System.Drawing.Size(72, 16);
			this.checkBoxReconnectOnFail.TabIndex = 7;
			this.checkBoxReconnectOnFail.Text = "断线重连";
			this.checkBoxReconnectOnFail.UseVisualStyleBackColor = true;
			this.checkBoxReconnectOnFail.CheckedChanged += new System.EventHandler(this.checkBoxReconnectOnFail_CheckedChanged);
			// 
			// notifyIcon
			// 
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "Auto p.nju";
			this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
			// 
			// groupBox
			// 
			this.groupBox.Controls.Add(this.labelBalanceValue);
			this.groupBox.Controls.Add(this.labelLoginTimeValue);
			this.groupBox.Controls.Add(this.labelAeraValue);
			this.groupBox.Controls.Add(this.labelIPValue);
			this.groupBox.Controls.Add(this.labelNameValue);
			this.groupBox.Controls.Add(this.labelUsernameValue);
			this.groupBox.Controls.Add(this.labelPayAmount);
			this.groupBox.Controls.Add(this.labelAera);
			this.groupBox.Controls.Add(this.labelLoginTime);
			this.groupBox.Controls.Add(this.labelIP);
			this.groupBox.Controls.Add(this.labelName);
			this.groupBox.Controls.Add(this.labelUsername2);
			this.groupBox.Location = new System.Drawing.Point(250, 12);
			this.groupBox.Name = "groupBox";
			this.groupBox.Size = new System.Drawing.Size(171, 171);
			this.groupBox.TabIndex = 8;
			this.groupBox.TabStop = false;
			this.groupBox.Text = "登录信息";
			// 
			// labelBalanceValue
			// 
			this.labelBalanceValue.AutoSize = true;
			this.labelBalanceValue.Location = new System.Drawing.Point(97, 147);
			this.labelBalanceValue.Name = "labelBalanceValue";
			this.labelBalanceValue.Size = new System.Drawing.Size(0, 12);
			this.labelBalanceValue.TabIndex = 11;
			// 
			// labelLoginTimeValue
			// 
			this.labelLoginTimeValue.AutoSize = true;
			this.labelLoginTimeValue.Location = new System.Drawing.Point(52, 126);
			this.labelLoginTimeValue.Name = "labelLoginTimeValue";
			this.labelLoginTimeValue.Size = new System.Drawing.Size(0, 12);
			this.labelLoginTimeValue.TabIndex = 10;
			this.labelLoginTimeValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelAeraValue
			// 
			this.labelAeraValue.AutoSize = true;
			this.labelAeraValue.Location = new System.Drawing.Point(73, 84);
			this.labelAeraValue.Name = "labelAeraValue";
			this.labelAeraValue.Size = new System.Drawing.Size(0, 12);
			this.labelAeraValue.TabIndex = 9;
			// 
			// labelIPValue
			// 
			this.labelIPValue.AutoSize = true;
			this.labelIPValue.Location = new System.Drawing.Point(61, 63);
			this.labelIPValue.Name = "labelIPValue";
			this.labelIPValue.Size = new System.Drawing.Size(0, 12);
			this.labelIPValue.TabIndex = 8;
			// 
			// labelNameValue
			// 
			this.labelNameValue.AutoSize = true;
			this.labelNameValue.Location = new System.Drawing.Point(49, 42);
			this.labelNameValue.Name = "labelNameValue";
			this.labelNameValue.Size = new System.Drawing.Size(0, 12);
			this.labelNameValue.TabIndex = 7;
			// 
			// labelUsernameValue
			// 
			this.labelUsernameValue.AutoSize = true;
			this.labelUsernameValue.Location = new System.Drawing.Point(61, 21);
			this.labelUsernameValue.Name = "labelUsernameValue";
			this.labelUsernameValue.Size = new System.Drawing.Size(41, 12);
			this.labelUsernameValue.TabIndex = 6;
			this.labelUsernameValue.Text = "未登录";
			// 
			// labelPayAmount
			// 
			this.labelPayAmount.AutoSize = true;
			this.labelPayAmount.Location = new System.Drawing.Point(11, 147);
			this.labelPayAmount.Name = "labelPayAmount";
			this.labelPayAmount.Size = new System.Drawing.Size(89, 12);
			this.labelPayAmount.TabIndex = 5;
			this.labelPayAmount.Text = "BRAS账户余额：";
			// 
			// labelAera
			// 
			this.labelAera.AutoSize = true;
			this.labelAera.Location = new System.Drawing.Point(11, 105);
			this.labelAera.Name = "labelAera";
			this.labelAera.Size = new System.Drawing.Size(65, 12);
			this.labelAera.TabIndex = 4;
			this.labelAera.Text = "登录时间：";
			// 
			// labelLoginTime
			// 
			this.labelLoginTime.AutoSize = true;
			this.labelLoginTime.Location = new System.Drawing.Point(11, 84);
			this.labelLoginTime.Name = "labelLoginTime";
			this.labelLoginTime.Size = new System.Drawing.Size(65, 12);
			this.labelLoginTime.TabIndex = 3;
			this.labelLoginTime.Text = "登录区域：";
			// 
			// labelIP
			// 
			this.labelIP.AutoSize = true;
			this.labelIP.Location = new System.Drawing.Point(11, 63);
			this.labelIP.Name = "labelIP";
			this.labelIP.Size = new System.Drawing.Size(53, 12);
			this.labelIP.TabIndex = 2;
			this.labelIP.Text = "IP地址：";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(11, 42);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(41, 12);
			this.labelName.TabIndex = 1;
			this.labelName.Text = "姓名：";
			// 
			// labelUsername2
			// 
			this.labelUsername2.AutoSize = true;
			this.labelUsername2.Location = new System.Drawing.Point(11, 21);
			this.labelUsername2.Name = "labelUsername2";
			this.labelUsername2.Size = new System.Drawing.Size(53, 12);
			this.labelUsername2.TabIndex = 0;
			this.labelUsername2.Text = "用户名：";
			// 
			// timer
			// 
			this.timer.Interval = 30000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(433, 195);
			this.Controls.Add(this.groupBox);
			this.Controls.Add(this.checkBoxReconnectOnFail);
			this.Controls.Add(this.buttonLogin);
			this.Controls.Add(this.checkBoxAutoLogin);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.textBoxUsername);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.labelUsername);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Auto p.nju by 喵叔";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.mainForm_Load);
			this.SizeChanged += new System.EventHandler(this.mainForm_SizeChanged);
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.groupBox.ResumeLayout(false);
			this.groupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelUsername;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.TextBox textBoxUsername;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.CheckBox checkBoxAutoLogin;
		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.CheckBox checkBoxReconnectOnFail;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.GroupBox groupBox;
		private System.Windows.Forms.Label labelPayAmount;
		private System.Windows.Forms.Label labelAera;
		private System.Windows.Forms.Label labelLoginTime;
		private System.Windows.Forms.Label labelIP;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelUsername2;
		private System.Windows.Forms.Timer timer;
		internal System.Windows.Forms.Label labelBalanceValue;
		internal System.Windows.Forms.Label labelLoginTimeValue;
		internal System.Windows.Forms.Label labelAeraValue;
		internal System.Windows.Forms.Label labelIPValue;
		internal System.Windows.Forms.Label labelNameValue;
		internal System.Windows.Forms.Label labelUsernameValue;
	}
}

