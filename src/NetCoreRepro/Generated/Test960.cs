using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test960
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass960>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
