using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test469
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass469>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}