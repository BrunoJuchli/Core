using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test671
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass671>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
