using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test18
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass18>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}