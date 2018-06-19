using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test430
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass430>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
