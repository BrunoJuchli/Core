using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test536
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass536>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
