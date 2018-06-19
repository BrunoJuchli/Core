using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test379
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass379>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
