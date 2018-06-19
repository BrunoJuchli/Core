using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test245
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass245>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
