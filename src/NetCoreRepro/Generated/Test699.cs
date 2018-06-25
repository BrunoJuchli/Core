using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test699
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass699>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}