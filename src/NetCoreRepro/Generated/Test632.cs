using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test632
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass632>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
