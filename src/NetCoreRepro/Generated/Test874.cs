using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test874
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass874>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}