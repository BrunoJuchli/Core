using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test24
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass24>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
