using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test727
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass727>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
