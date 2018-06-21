using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test654
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass654>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
