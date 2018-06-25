using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test74
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass74>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}