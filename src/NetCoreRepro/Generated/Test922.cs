using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test922
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass922>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}