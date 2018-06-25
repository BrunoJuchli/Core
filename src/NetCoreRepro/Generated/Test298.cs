using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test298
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass298>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}