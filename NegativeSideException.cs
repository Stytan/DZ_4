using System;

namespace DZ_4
{
	[Serializable]
	/// <summary>
	/// Исключение - введены отрицательные значения
	/// </summary>
	public class NegativeSideException : ApplicationException
	{
		public NegativeSideException()
			: base("A negative value for the side is set")
		{}

		public NegativeSideException(string message)
			: base(message)
		{}

		public NegativeSideException(string message, Exception inner)
			: base(message, inner)
		{}

		protected NegativeSideException(System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context)
			: base(info, context)
		{}
	}
}
