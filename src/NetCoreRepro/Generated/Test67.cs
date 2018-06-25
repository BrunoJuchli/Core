using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test67
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass67>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}