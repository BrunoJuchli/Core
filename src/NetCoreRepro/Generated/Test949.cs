using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test949
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass949>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
