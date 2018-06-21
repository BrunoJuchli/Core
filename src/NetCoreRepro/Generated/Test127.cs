using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test127
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass127>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
