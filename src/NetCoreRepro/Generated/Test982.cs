using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test982
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass982>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
