using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test847
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass847>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
