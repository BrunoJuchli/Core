using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test92
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass92>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
