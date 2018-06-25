using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test761
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass761>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}