using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test686
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass686>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
