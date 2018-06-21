using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test306
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass306>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
