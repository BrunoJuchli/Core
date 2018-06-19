using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test332
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass332>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
