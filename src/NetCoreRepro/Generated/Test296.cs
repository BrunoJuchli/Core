using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test296
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass296>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
