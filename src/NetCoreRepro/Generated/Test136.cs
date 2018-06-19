using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test136
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass136>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
