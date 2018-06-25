using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test388
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass388>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}