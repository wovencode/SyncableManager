// =======================================================================================
// Wovencore
// by Weaver (Fhiz)
// MIT licensed
// =======================================================================================

using System;
using System.Collections.Generic;
using UnityEngine;
using wovencode;

namespace wovencode {
	
	// ===================================================================================
	// DataCache
	// ===================================================================================
	public partial class DataCache : BaseCache
	{
	
		protected Dictionary<int, DataCacheEntry> cacheEntries = new Dictionary<int, DataCacheEntry>();
		
		// -------------------------------------------------------------------------------
		// DataCache (Constructor) 
		// -------------------------------------------------------------------------------
		public DataCache(double _cacheUpdateInterval) : base(_cacheUpdateInterval)
		{
		
		}
	
	}

}

// =======================================================================================