using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test121
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass121>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}