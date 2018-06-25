using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test598
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass598>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}