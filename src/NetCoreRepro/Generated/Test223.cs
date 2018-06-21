using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test223
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass223>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
