using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test483
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass483>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
