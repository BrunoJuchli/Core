using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test98
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass98>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
