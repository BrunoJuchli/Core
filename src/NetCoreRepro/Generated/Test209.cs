using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test209
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass209>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
