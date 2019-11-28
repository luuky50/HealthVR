using System;

namespace UniFix
{
	/// <summary> MADE BY: Mathias Bevers
	/// This is a part of MonoBehaviourExtra, to throw a custom Exception.
	/// </summary>
	/// <remarks>
	/// There was, in my opinion, not an existing Exception that fits this Error.
	/// </remarks>
	public class NoComponentFoundException : Exception
	{
		public NoComponentFoundException(string componentName) : base(string.Format($"There is no {componentName} component found."))
		{

		}
	}
}