using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test518
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass518>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}