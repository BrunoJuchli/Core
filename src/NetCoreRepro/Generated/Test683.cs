using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test683
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass683>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
