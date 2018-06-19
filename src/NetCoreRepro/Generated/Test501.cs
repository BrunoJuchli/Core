using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test501
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass501>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
