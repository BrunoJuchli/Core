using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test222
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass222>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}