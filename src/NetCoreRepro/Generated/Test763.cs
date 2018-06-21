using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test763
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass763>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
