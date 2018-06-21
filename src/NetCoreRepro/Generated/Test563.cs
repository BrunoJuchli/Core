using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test563
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass563>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
