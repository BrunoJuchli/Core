using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test738
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass738>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
