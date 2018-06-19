using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test299
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass299>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
