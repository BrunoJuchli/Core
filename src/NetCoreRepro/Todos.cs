namespace NetCoreRepro
{
	/*
	 *	CacheKey is not immutable.
	 *		--> make immutable
	 *		--> ProxyGenerationOptions: is not immutable but is used as part of dictionary key. What's worse, ProxyGenerationOptions.Default is a "global" instance that is
	 *		used per default but anyone can change.
	 *
	 *	Rewrite ModuleScope, NamingScope so reading operations are only available on Read-Lock-Scope-Interface
	 *	and Writing operations are only available on Write-Lock-Scope-Interface
	 *
	 *
	 */
}
