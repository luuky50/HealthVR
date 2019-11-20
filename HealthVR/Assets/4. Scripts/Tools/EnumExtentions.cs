using System;
using System.Collections;
using System.Collections.Generic;

namespace UniFix
{
	public static class EnumExtentions<TEnum>
	{
		public static int Count => Enum.GetNames(typeof(TEnum)).Length;

		public static TEnum Random
		{
			get
			{
				if (!typeof(TEnum).IsEnum)
				{
					throw new ArgumentException("TEnum is not an enum");
				}

				int count = Enum.GetNames(typeof(TEnum)).Length;
				int randomNumber = UnityEngine.Random.Range(0, count);

				TEnum randomizedEnum = (TEnum)Enum.ToObject(typeof(TEnum), randomNumber);

				return randomizedEnum;
			}
		}
	}
}