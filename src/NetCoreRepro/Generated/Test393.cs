using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test393
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass393>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}