using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test376
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass376>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
