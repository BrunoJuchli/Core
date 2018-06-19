using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test193
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass193>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
