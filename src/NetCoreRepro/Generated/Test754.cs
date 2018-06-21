using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test754
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass754>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
