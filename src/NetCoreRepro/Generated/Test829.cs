using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test829
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass829>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
