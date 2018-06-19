using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test849
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass849>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
