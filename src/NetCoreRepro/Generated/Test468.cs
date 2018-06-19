using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test468
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass468>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
