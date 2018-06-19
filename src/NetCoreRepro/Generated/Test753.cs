using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test753
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass753>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
