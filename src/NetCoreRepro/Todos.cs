namespace NetCoreRepro
{
	/*
	 *	CacheKey is not immutable.
	 *		--> make immutable
	 *		--> ProxyGenerationOptions: is not immutable but is used as part of dictionary key. What's worse, ProxyGenerationOptions.Default is a "global" instance that is
	 *		used per default but anyone can change.
	 *
	 *
	 *
	 *
	 */
}
