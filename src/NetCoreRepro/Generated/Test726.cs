using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test726
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass726>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
