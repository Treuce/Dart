using Mono.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace DaRT.Helpers
{
	public static class WebClientAsd
	{
		static WebClient webClient = new WebClient();
		public static string GetUID(string guid)
		{
			try
			{
				lock (webClient)
				{
					
					ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072; //TLS 1.2
					webClient.Encoding = Encoding.UTF8;
					webClient.Headers.Add("user-agent", "");
					string SteamIDResponse = webClient.DownloadString("https://beguid-converter.allianceapps.io/v3/" + guid);
					
					if (SteamIDResponse.IndexOf("\"error\":true") > -1)
					{
						throw new Exception("Received error from webclient");
					}
					else
					{
						//Console.WriteLine("No error");
						int index = SteamIDResponse.IndexOf("\"steamid\":\"");
						string SteamID = SteamIDResponse.Substring(index + 11, 17);
						return SteamID;
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"{ex}");
				return "Error";
			}
		}
		public static void GetUID(string guid, Player player)
		{
			try
			{
				lock (webClient)
				{
					WebClient webClient = new WebClient();
					webClient.Encoding = Encoding.UTF8;
					//webClient.Headers.Add("user-agent", "");
					string SteamIDResponse = webClient.DownloadString("https://beguid-converter.allianceapps.io/v3/" + guid);
					//webClient.Dispose();

					if (SteamIDResponse.IndexOf("\"error\":true") > -1)
					{
						throw new Exception("Received error from webclient");
					}
					else
					{
						//Console.WriteLine("No error");
						int index = SteamIDResponse.IndexOf("\"steamid\":\"");
						string SteamID = SteamIDResponse.Substring(index + 11, 17);
						//player.SteamID = SteamID;

						using (SqliteCommand command = new SqliteCommand(
							$"update Players set UID='{SteamID}' where GUID='{guid}'", (new SqliteConnection(@"Data Source=data\db\dart.db"))
							))
						{
							command.ExecuteNonQuery();
						}
					}
				}
			}
			catch (Exception ex)
			{
		
			}
		}
		#region IP Stuff


		/// <summary>
		/// Get IP Information from an IP address, country code, location, ISP etc
		/// </summary>
		/// <param name="IP">The IP to use</param>
		/// <returns>Country Code</returns>
		public static string GetIPLocation(string IP)
		{
			try
			{
				lock (webClient)
				{
					string strReturnVal;
					string ipResponse = IPRequestHelper("http://ip-api.com/xml/" + IP);

					XmlDocument ipInfoXML = new XmlDocument();
					ipInfoXML.LoadXml(ipResponse);
					XmlNodeList responseXML = ipInfoXML.GetElementsByTagName("query");

					NameValueCollection dataXML = new NameValueCollection();

					dataXML.Add(responseXML.Item(0).ChildNodes[2].InnerText, responseXML.Item(0).ChildNodes[2].Value);

					Console.WriteLine($"{ipResponse}");
		
					strReturnVal = responseXML.Item(0).ChildNodes[1].InnerText.ToString(); // Contry
					strReturnVal = "(" +
					responseXML.Item(0).ChildNodes[2].InnerText.ToString() + ")";  // Country Code 
					return strReturnVal;

				}
			}
			catch (Exception ex)
			{
				return "";
			}
		}


		/// <summary>
		/// Get IP Information from an IP address, country code, location, ISP etc and assign it to <see cref="Player"/>
		/// </summary>
		/// <param name="IP"></param>
		/// <param name="a">Player to assign the Country Code to.</param>
		/// <returns></returns>
		/// 

		public static void GetIPLocation(string IP, Player a)
		{
			try
			{
				lock (webClient)
				{
					string strReturnVal;
					string ipResponse = IPRequestHelper("http://ip-api.com/xml/" + IP);

					XmlDocument ipInfoXML = new XmlDocument();
					ipInfoXML.LoadXml(ipResponse);
					XmlNodeList responseXML = ipInfoXML.GetElementsByTagName("query");

					NameValueCollection dataXML = new NameValueCollection();

					dataXML.Add(responseXML.Item(0).ChildNodes[2].InnerText, responseXML.Item(0).ChildNodes[2].Value);

					strReturnVal = responseXML.Item(0).ChildNodes[1].InnerText.ToString(); // Contry
					strReturnVal = "(" +
					responseXML.Item(0).ChildNodes[2].InnerText.ToString() + ")";  // Country Code 

				}
			}
			catch (Exception ex)
			{
			}
		}
		#endregion

		#region Helpers
		/// <summary>
		/// Helper for <see cref="GetIPLocation(string)"/>
		/// </summary>
		/// <param name="url"></param>
		/// <returns></returns>
		public static string IPRequestHelper(string url)
		{

			HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);
			HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();

			StreamReader responseStream = new StreamReader(objResponse.GetResponseStream());
			string responseRead = responseStream.ReadToEnd();

			responseStream.Close();
			responseStream.Dispose();

			return responseRead;
		}



		/// <summary>
		/// Converts Steam64 ID to Battleye GUID
		/// </summary>
		/// <param name="steamID">string SteamID</param>
		/// <returns></returns>
		public static string SteamIDToGUID(string steamID)
		{
			Int64 SteamId = Convert.ToInt64(steamID);
			byte[] parts = { 0x42, 0x45, 0, 0, 0, 0, 0, 0, 0, 0 };
			byte counter = 2;

			do
			{
				parts[counter++] = (byte)(SteamId & 0xFF);
			} while ((SteamId >>= 8) > 0);

			MD5 md5 = new MD5CryptoServiceProvider();
			byte[] beHash = md5.ComputeHash(parts);
			StringBuilder guid = new StringBuilder();
			for (int i = 0; i < beHash.Length; i++)
			{
				guid.Append(beHash[i].ToString("x2"));
			}
			//Console.WriteLine($"UID: {steamID}");
			//Console.WriteLine($"GUID: {guid.ToString()}");

			return guid.ToString();
		}
		#endregion
	}
}
