using System;
using System.Collections;
using System.Collections.Generic;

public static class EnumExtentions<TEnum>
{
	public static TEnum GetRandomEnum()
	{
		if(!typeof(TEnum).IsEnum)
		{
			throw new ArgumentException("TEnum is not an enum.");
		}

		int enumCount = Enum.GetNames(typeof(TEnum)).Length;
		int randomEnumNumber = UnityEngine.Random.Range(0, enumCount);

		TEnum randomEnum = (TEnum)Enum.ToObject(typeof(TEnum), randomEnumNumber);

		return randomEnum;
	}
}