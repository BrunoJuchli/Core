using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test998
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass998>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
