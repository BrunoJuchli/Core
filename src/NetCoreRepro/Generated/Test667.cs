using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test667
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass667>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}