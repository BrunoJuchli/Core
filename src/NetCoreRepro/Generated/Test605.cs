using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test605
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass605>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
