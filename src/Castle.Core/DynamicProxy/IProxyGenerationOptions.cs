namespace Castle.DynamicProxy
{
	using System;
	using System.Collections.Generic;

	public interface IProxyGenerationOptions
	{
		IProxyGenerationHook Hook { get; }
		IInterceptorSelector Selector { get; }
		Type BaseTypeForInterfaceProxy { get; }
		IList<CustomAttributeInfo> AdditionalAttributes { get; }
		MixinData MixinData { get; }
		bool HasMixins { get; }
	}
}