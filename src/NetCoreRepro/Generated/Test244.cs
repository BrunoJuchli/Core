using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test244
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass244>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}