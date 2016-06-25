using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;

namespace Auto_p.nju_desktop
{
	class AutoConnect
	{
		public const int LOGIN_SUCCESS = 1;
		public const int INVALID_PASSWORD = 3;
		public const int ALREADY_LOGGED_IN = 6;
        public const int PROCESSING = 253;

		private const String LOGIN_URL = "http://p.nju.edu.cn/portal_io/login";

		public static OnlineMessage connect(String username,String password)
		{
			String postData = "username=" + username + "&password=" + password;

			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(LOGIN_URL);
			request.Method = "POST";
			request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";

			try
			{
				Stream requestStream = request.GetRequestStream();
				StreamWriter streamWriter = new StreamWriter(requestStream, Encoding.ASCII);
				streamWriter.Write(postData);
				streamWriter.Close();

				HttpWebResponse response = (HttpWebResponse)request.GetResponse();
				Stream responseStream = response.GetResponseStream();
				DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ReturnMessage));
				ReturnMessage returnMessage = (ReturnMessage)serializer.ReadObject(responseStream);
				responseStream.Close();

				switch(returnMessage.reply_code)
				{
					case LOGIN_SUCCESS:
					case ALREADY_LOGGED_IN:
						return OnlineState.getOnlineStateStrict();
					case INVALID_PASSWORD:
						OnlineMessage onlineMessage = new OnlineMessage();
						onlineMessage.reply_code = returnMessage.reply_code;
						onlineMessage.reply_msg = returnMessage.reply_msg;
						onlineMessage.userinfo = null;
						return onlineMessage;
                    case PROCESSING:
                    default:
						return null;
				}
			}
			catch
			{
				return null;
			}
		}
	}

	[DataContract]
	internal class UserInfo
	{
		[DataMember]
		internal String username;
		[DataMember]
		internal uint useripv4;
		[DataMember]
		internal long acctstarttime;
		[DataMember]
		internal String fullname;
		[DataMember]
		internal String area_name;
		[DataMember]
		internal float balance;
	}

	[DataContract]
	internal class ReturnMessage
	{
		[DataMember]
		internal int reply_code;
		[DataMember]
		internal String reply_msg;
		[DataMember]
		internal UserInfo userinfo;
	}
}
