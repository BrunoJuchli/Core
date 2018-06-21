using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test399
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass399>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
