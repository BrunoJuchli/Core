using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test459
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass459>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
