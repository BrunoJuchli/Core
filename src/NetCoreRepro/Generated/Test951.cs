using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test951
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass951>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
