using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test238
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass238>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
