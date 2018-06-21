using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test89
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass89>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
