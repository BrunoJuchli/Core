using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test630
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass630>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}