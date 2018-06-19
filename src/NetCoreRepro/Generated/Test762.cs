using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test762
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass762>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
