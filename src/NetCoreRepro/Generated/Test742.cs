using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test742
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass742>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
