using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test897
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass897>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
