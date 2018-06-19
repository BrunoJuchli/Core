using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test251
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass251>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
