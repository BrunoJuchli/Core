using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test378
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass378>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
