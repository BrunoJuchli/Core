using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test119
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass119>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
