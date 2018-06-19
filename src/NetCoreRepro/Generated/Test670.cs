using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test670
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass670>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
