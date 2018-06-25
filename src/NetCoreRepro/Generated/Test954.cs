using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test954
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass954>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}