using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test977
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass977>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
