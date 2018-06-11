using Microsoft.Extensions.Caching.Memory;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_InMemory
{
	public class MemoryCacheRegistry : Registry
	{
		public MemoryCacheRegistry()
		{
			For<IMemoryCache>().Use(() => new MemoryCache(new MemoryCacheOptions())).Singleton();

			//var memoryCache = new MemoryCache(new MemoryCacheOptions());
			//For<IMemoryCache>().Use(memoryCache);
		}
	}
}