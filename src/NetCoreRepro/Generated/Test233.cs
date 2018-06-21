using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test233
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass233>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
