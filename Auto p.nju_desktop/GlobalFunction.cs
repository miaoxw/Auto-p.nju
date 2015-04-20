using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_p.nju_desktop
{
	class GlobalFunction
	{
		public static void showInfo(ReturnMessage message,MainForm form)
		{
			form.labelAeraValue.Text = message.userinfo.area_name;

			uint IPUint = message.userinfo.userip;
			String frnendlyIPAddress = ((IPUint >> 24) & 0xFF) + "." + ((IPUint >> 16) & 0xFF) + "." + ((IPUint >> 8) & 0xFF) + "." + ((IPUint >> 8) & 0xFF);
			form.labelIPValue.Text = frnendlyIPAddress;
			DateTime time = GlobalFunction.unixTimestamp2DateTime(message.userinfo.acctstarttime*1000);
			form.labelLoginTimeValue.Text = time.ToLocalTime().ToString();
			form.labelNameValue.Text = message.userinfo.fullname;
			form.labelPayAmountValue.Text = message.userinfo.payamount.ToString("#.00");
			form.labelUsernameValue.Text = message.userinfo.username;
		}

		public static void showInfo(OnlineMessage message, MainForm form)
		{
			form.labelAeraValue.Text = message.userinfo.area_name;

			form.labelIPValue.Text = message.userinfo.user_ip;
			DateTime time = GlobalFunction.unixTimestamp2DateTime(message.userinfo.acctstarttime * 1000);
			form.labelLoginTimeValue.Text = time.ToLocalTime().ToString();
			form.labelNameValue.Text = message.userinfo.fullname;
			form.labelPayAmountValue.Text = message.userinfo.payamount.ToString("#.00");
			form.labelUsernameValue.Text = message.userinfo.username;
		}

		public static DateTime unixTimestamp2DateTime(long timeStamp)
		{
			DateTime time = DateTime.MinValue;
			DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
			time = startTime.AddMilliseconds(timeStamp);
			return time;
		}


	}
}
