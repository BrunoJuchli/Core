using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test986
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass986>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
