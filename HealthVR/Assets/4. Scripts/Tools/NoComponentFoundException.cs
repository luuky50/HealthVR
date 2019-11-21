using System;

namespace UniFix
{
	public class NoComponentFoundException : Exception
	{
		public NoComponentFoundException(string componentName) : base(string.Format($"There is no {componentName} component found."))
		{

		}
	}
}