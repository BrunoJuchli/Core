using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test554
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass554>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}