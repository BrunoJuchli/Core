using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test931
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass931>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
