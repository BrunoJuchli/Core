using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test719
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass719>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}