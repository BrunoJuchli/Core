using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test882
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass882>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
