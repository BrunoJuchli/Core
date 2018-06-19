using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test553
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass553>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
