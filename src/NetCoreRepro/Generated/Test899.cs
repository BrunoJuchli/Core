using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test899
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass899>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
