using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test27
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass27>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
