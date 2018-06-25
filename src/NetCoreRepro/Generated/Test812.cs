using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test812
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass812>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}