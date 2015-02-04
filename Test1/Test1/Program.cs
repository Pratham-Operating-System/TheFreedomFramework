using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using System.ServiceModel;

namespace Test1
{
	[ServiceContract]
	public class foo
	{
	}
	class MainClass
	{
		
		public static void Main (string[] args)
		{
			//Console.WriteLine ("Hello World!");
			string ss = Downc().Result;
			Console.WriteLine (ss);
			//Task t 
			List<string> s = new List<string>();

			var dd = from aa in s
			         where aa.Length > 1
			         select aa;
			
		}
		public static async Task<string> Downc()
		{
			using (HttpClient hc = new HttpClient ()) {
				string ss = await hc.GetStringAsync ("http://www.prathamos.org");
				return ss;
			}
		}
	}
}
