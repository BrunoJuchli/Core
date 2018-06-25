using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test878
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass878>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}