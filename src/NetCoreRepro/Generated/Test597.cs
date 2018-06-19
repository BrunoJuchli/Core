using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test597
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass597>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
