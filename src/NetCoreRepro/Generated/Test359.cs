using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test359
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass359>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}