using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace socktest
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Class1
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			UdpClient udpClient = new UdpClient(7600);
			//IPAddress ipAddress = Dns.Resolve("muscat.cs.tcd.ie").AddressList[0];
			IPAddress ipAddress= IPAddress.Parse("127.0.0.1");
			IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 7600);   

			Byte[] sendBytes = Encoding.ASCII.GetBytes("Is anybody there?");

			try
			{
				Console.WriteLine("Sending to address {0}", ipAddress.ToString());
				int ecode = udpClient.Send(sendBytes, sendBytes.Length, ipEndPoint);
				Console.WriteLine("ecode={0}", ecode);
			}
			catch ( Exception e )
			{
				Console.WriteLine(e.ToString());   
			}		
		}
	}
}
