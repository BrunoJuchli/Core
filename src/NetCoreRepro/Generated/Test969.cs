using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test969
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass969>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
