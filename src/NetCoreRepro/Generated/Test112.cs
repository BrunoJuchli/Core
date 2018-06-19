using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test112
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass112>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
