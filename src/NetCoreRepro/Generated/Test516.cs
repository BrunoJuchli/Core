using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test516
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass516>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
