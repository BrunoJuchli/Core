using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test811
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass811>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
