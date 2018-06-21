using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test708
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass708>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
