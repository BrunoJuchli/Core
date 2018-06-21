using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test964
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass964>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
