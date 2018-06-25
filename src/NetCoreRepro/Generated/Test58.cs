using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test58
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass58>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}