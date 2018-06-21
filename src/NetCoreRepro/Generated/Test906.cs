using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test906
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass906>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
