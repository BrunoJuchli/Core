using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test418
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass418>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
