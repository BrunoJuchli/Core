using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test999
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass999>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
