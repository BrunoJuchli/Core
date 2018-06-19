using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test185
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass185>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
