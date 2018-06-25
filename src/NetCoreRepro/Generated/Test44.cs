using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test44
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass44>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}