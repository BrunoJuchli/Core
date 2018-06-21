using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test520
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass520>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
