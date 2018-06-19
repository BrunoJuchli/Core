using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test305
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass305>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
