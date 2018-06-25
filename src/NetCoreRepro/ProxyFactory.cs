using System;
using Castle.DynamicProxy;

namespace NetCoreRepro
{
	public static class ProxyFactory
	{
		static readonly Interceptor interceptor = new Interceptor();

		public static T CreateProxy<T>() where T : class
		{
			return new ProxyGenerator().CreateInterfaceProxyWithoutTarget<T>(interceptor);
		}

		private sealed class Interceptor : IInterceptor
		{
			public void Intercept(IInvocation invocation)
			{
				if (invocation.Method.ReturnType == typeof(void))
				{
				}
				else if (invocation.Method.ReturnType == typeof(bool))
				{
					invocation.ReturnValue = true;
				}
				else
				{
					invocation.ReturnValue = Activator.CreateInstance(invocation.Method.ReturnType);
				}
			}
		}
	}
}
