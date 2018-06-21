using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test133
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass133>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
