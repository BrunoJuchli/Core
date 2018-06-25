using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test920
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass920>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}