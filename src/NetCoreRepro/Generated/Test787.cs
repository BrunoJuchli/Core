using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test787
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass787>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
