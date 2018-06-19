using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test788
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass788>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
