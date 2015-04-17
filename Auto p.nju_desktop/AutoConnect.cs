using System;
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
	class AutoConnect
	{
		public static ReturnMessage connect(String username,String password)
		{
			String postData = "action=login&username=" + username + "&password=" + password;

			HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://p.nju.edu.cn/portal/portal_io.do");
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

				return returnMessage;
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
		internal uint userip;
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
	internal class ReturnMessage
	{
		[DataMember]
		internal int reply_code;
		[DataMember]
		internal String reply_message;
		[DataMember]
		internal UserInfo userinfo;
	}
}
