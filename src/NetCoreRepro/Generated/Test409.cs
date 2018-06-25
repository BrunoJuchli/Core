using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test409
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass409>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}