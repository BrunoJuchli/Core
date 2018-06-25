using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test190
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass190>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}