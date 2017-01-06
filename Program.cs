namespace ThreadSafeSingleton
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Singleton singleton = Singleton.Instance;
		}
	}
}
