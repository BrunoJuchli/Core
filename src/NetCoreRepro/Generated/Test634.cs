using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test634
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass634>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}