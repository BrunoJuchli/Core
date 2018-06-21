using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test585
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass585>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
