using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test994
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass994>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
