using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test145
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass145>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}