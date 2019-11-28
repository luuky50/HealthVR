using System;

namespace UniFix
{
	/// <summary> MADE BY: Mathias Bevers
	/// The syntax for some enum functions is a bit strange, this helps making it a bit more clear.
	/// </summary>
	/// <typeparam name="TEnum">The enum to use one of the functions</typeparam>
	public static class EnumExtensions<TEnum>
	{
		/// <summary>
		/// Gives back the amount of enum members.
		/// </summary>
		public static int Count => Enum.GetNames(typeof(TEnum)).Length;

		/// <summary>
		/// Gives back one random enum from the enum members. 
		/// </summary>
		public static TEnum Random
		{
			get
			{
				if (!typeof(TEnum).IsEnum)
				{
					throw new ArgumentException($"{typeof(TEnum).Name} is not an enum");
				}

				int count = Enum.GetNames(typeof(TEnum)).Length;
				int randomNumber = UnityEngine.Random.Range(0, count);

				TEnum randomizedEnum = (TEnum)Enum.ToObject(typeof(TEnum), randomNumber);

				return randomizedEnum;
			}
		}
	}
}