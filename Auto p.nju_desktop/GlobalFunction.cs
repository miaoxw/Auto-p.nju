using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_p.nju_desktop
{
	class GlobalFunction
	{
		//There's nowhere to use this function now, but stay it here in case.
		private static void showInfo(ReturnMessage message, MainForm form)
		{
			form.labelAeraValue.Text = message.userinfo.area_name;

			uint IPUint = message.userinfo.useripv4;
			String frnendlyIPAddress = ((IPUint >> 24) & 0xFF) + "." + ((IPUint >> 16) & 0xFF) + "." + ((IPUint >> 8) & 0xFF) + "." + (IPUint & 0xFF);
			form.labelIPValue.Text = frnendlyIPAddress;
			DateTime time = GlobalFunction.unixTimestamp2DateTime(message.userinfo.acctstarttime * 1000);
			form.labelLoginTimeValue.Text = time.ToLocalTime().ToString();
			if (message.userinfo != null)
			{
				form.labelNameValue.Text = message.userinfo.fullname;
				form.labelBalanceValue.Text = message.userinfo.balance.ToString("#.00");
				form.labelUsernameValue.Text = message.userinfo.username;
			}
		}

		public static void showInfo(OnlineMessage message, MainForm form)
		{
			if (message != null && message.userinfo != null)
			{
				form.labelAeraValue.Text = message.userinfo.area_name;

				form.labelIPValue.Text = UintIP2String(message.userinfo.useripv4);
				DateTime time = GlobalFunction.unixTimestamp2DateTime(message.userinfo.acctstarttime * 1000);
				form.labelLoginTimeValue.Text = time.ToLocalTime().ToString();
				form.labelNameValue.Text = message.userinfo.fullname;
				String balance = message.userinfo.balance / 100 + ".";
				balance += message.userinfo.balance % 100 < 10 ? ("0" + (message.userinfo.balance % 100).ToString()) : (message.userinfo.balance % 100).ToString();
				form.labelBalanceValue.Text = balance;
				form.labelUsernameValue.Text = message.userinfo.username;
			}
			else
			{
				if (message.reply_code == AutoConnect.INVALID_PASSWORD)
					form.labelUsernameValue.Text = "密码错误";
				else
					form.labelUsernameValue.Text = "未登录";
				form.labelNameValue.Text = "";
				form.labelIPValue.Text = "";
				form.labelAeraValue.Text = "";
				form.labelLoginTimeValue.Text = "";
				form.labelBalanceValue.Text = "";
			}
		}

		public static DateTime unixTimestamp2DateTime(long timeStamp)
		{
			DateTime time = DateTime.MinValue;
			DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
			time = startTime.AddMilliseconds(timeStamp);
			return time;
		}

		public static String UintIP2String(uint IPUint)
		{
			String friendlyIPAddress = ((IPUint >> 24) & 0xFF) + "." + ((IPUint >> 16) & 0xFF) + "." + ((IPUint >> 8) & 0xFF) + "." + (IPUint & 0xFF);
			return friendlyIPAddress;
		}
	}
}
