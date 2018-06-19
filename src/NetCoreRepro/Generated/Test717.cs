using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test717
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass717>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
