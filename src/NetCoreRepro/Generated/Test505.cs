using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test505
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass505>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}