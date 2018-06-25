using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test970
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass970>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}