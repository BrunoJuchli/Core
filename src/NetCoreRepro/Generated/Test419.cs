using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test419
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass419>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
