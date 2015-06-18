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

			uint IPUint = message.userinfo.useripv4;
			String frnendlyIPAddress = ((IPUint >> 24) & 0xFF) + "." + ((IPUint >> 16) & 0xFF) + "." + ((IPUint >> 8) & 0xFF) + "." + (IPUint & 0xFF);
			form.labelIPValue.Text = frnendlyIPAddress;
			DateTime time = GlobalFunction.unixTimestamp2DateTime(message.userinfo.acctstarttime*1000);
			form.labelLoginTimeValue.Text = time.ToLocalTime().ToString();
			if (message.userinfo != null)
			{
				form.labelNameValue.Text = message.userinfo.fullname;
				form.labelPayAmountValue.Text = message.userinfo.balance.ToString("#.00");
				form.labelUsernameValue.Text = message.userinfo.username;
			}
		}

		public static void showInfo(OnlineMessage message, MainForm form)
		{
			//if (message.results != null)
			//{
				form.labelAeraValue.Text = message.results.area_name;

				form.labelIPValue.Text = message.results.user_ip;
				DateTime time = GlobalFunction.unixTimestamp2DateTime(message.results.acctstarttime * 1000);
				form.labelLoginTimeValue.Text = time.ToLocalTime().ToString();
				form.labelNameValue.Text = message.results.fullname;
				form.labelPayAmountValue.Text = message.results.payamount.ToString("#.00");
				form.labelUsernameValue.Text = message.results.username;
			//}
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
