using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test993
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass993>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}