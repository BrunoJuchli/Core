using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test866
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass866>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
