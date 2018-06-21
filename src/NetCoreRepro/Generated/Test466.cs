using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test466
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass466>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
