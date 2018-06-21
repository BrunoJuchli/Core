using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test194
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass194>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
