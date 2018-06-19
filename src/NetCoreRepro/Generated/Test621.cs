using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test621
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass621>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
