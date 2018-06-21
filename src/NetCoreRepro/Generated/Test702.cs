using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test702
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass702>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
