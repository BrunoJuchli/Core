using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test160
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass160>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
