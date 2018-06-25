using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test408
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass408>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}