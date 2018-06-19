using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test429
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass429>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
