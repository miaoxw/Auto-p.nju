﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Auto_p.nju_desktop
{
	class OnlineState
	{
		public static OnlineMessage getOnlineState()
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://p.nju.edu.cn/portal_io/proxy/userinfo");
			request.Method = "POST";

			try
			{
				OnlineMessage returnMessage=null;
				do
				{
					Stream requestStream = request.GetRequestStream();

					HttpWebResponse response = (HttpWebResponse)request.GetResponse();
					Stream responseStream = response.GetResponseStream();
					DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(OnlineMessage));
					returnMessage = (OnlineMessage)serializer.ReadObject(responseStream);
					responseStream.Close();
				} while (returnMessage == null);

				return returnMessage;
			}
			catch
			{

				return null;
			}
		}

		public static OnlineMessage getOnlineStateStrict()
		{
			OnlineMessage returnMessage = null;
			do
			{
				returnMessage = getOnlineState();
			} while (returnMessage == null || returnMessage.results == null);
			return returnMessage;
		}
	}

	[DataContract]
	internal class UserOnlineInfo
	{
		[DataMember]
		internal String username;
		[DataMember]
		internal String user_ip;
		[DataMember]
		internal long acctstarttime;
		[DataMember]
		internal String fullname;
		[DataMember]
		internal String area_name;
		[DataMember]
		internal float payamount;
	}

	[DataContract]
	internal class OnlineMessage
	{
		[DataMember]
		internal int reply_code;
		[DataMember]
		internal String reply_msg;
		[DataMember]
		internal UserOnlineInfo results;
	}
}
