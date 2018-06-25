using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test68
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass68>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}