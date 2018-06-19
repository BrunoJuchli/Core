using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test979
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass979>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
