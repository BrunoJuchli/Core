using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test524
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass524>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
