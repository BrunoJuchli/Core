using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test724
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass724>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
