using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test679
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass679>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
