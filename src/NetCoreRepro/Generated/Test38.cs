using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test38
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass38>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}