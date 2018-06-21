using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test704
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass704>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
