using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test84
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass84>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}