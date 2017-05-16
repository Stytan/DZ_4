using System;

namespace DZ_4
{
	[Serializable]
	/// <summary>
	/// Исключение - невозможно создать фигуру
	/// </summary>
	public class CreatingObjectException : ApplicationException
	{
		public CreatingObjectException()
			: base("Can't create a figure with the specified parameters")
		{}

		public CreatingObjectException(string message)
			: base(message)
		{}

		public CreatingObjectException(string message, Exception inner)
			: base(message, inner)
		{}

		protected CreatingObjectException(System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context)
			: base(info, context)
		{}
	}
}
