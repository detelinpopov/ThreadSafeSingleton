using System;

namespace ThreadSafeSingleton
{
	/// <summary>
	///     Thread-safe Singleton using Lazy
	/// </summary>
	public sealed class Singleton
	{
		private static readonly Lazy<Singleton> instanceHolder = new Lazy<Singleton>(() => new Singleton());

		private Singleton()
		{}

		public static Singleton Instance
		{
			get { return instanceHolder.Value; }
		}
	}
}
