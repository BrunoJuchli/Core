using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test484
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass484>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
