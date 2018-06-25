using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test926
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass926>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}