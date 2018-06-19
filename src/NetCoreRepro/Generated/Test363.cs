using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test363
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass363>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
