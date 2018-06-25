using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test869
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass869>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}