﻿using System;

namespace MethodCache
{
	/// <summary>
	/// Cache the output of this method or methods of this class.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class , AllowMultiple = false, Inherited = false)]
	public class CacheAttribute : Attribute
	{
	}
}
