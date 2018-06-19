using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test277
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass277>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
