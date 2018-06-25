using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test294
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass294>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}