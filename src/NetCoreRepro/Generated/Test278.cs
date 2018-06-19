using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test278
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass278>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
