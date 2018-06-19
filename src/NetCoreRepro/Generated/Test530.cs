using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test530
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass530>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
