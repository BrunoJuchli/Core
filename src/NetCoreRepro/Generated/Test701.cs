using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test701
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass701>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
