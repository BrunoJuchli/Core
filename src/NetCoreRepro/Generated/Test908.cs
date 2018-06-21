using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test908
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass908>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
