using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test50
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass50>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
