using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test385
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass385>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
