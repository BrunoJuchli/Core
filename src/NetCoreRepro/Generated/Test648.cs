using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test648
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass648>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
