using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test83
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass83>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
