using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test30
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass30>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
