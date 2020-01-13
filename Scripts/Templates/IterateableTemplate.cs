﻿// =======================================================================================
// Wovencore
// by Weaver (Fhiz)
// MIT licensed
// =======================================================================================

using System;
using UnityEngine;
using wovencode;

namespace wovencode {
	
	// ===================================================================================
	// IterateableTemplate
	// ===================================================================================
	public abstract partial class IterateableTemplate : BaseTemplate
	{
		
		[Header("Settings")]
		[Tooltip("Allows to adjust the impact of this object (mostly for modifiers)")]
		public int level;
		
		
		[Header("Active Modifiers")]
#if WOCO_CURRENCY
    	public GenerateCurrencyModifier[] autoGenerateCurrencyModifier;
#endif

		// -------------------------------------------------------------------------------
		
	}

}

// =======================================================================================