using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test601
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass601>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
