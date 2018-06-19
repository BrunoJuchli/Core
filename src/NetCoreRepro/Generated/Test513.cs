using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test513
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass513>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
