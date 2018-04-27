using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Singleton
{

	public class LazySingleton
	{
		private static readonly LazySingleton _instance = new LazySingleton();

		// Having a static constructor forces CLR to instantiate it just before the first use
		static LazySingleton () { }

		private LazySingleton()
		{
			Console.WriteLine("LazySingleton is getting instantiated");
		}

		public static LazySingleton Instance
		{
			get
			{
				return _instance;
			}
		}

		public static void DoSomething()
		{
			Console.WriteLine("LazySingleton is Doing something");
		}
	}

	public class VeryLazySingleton
	{

		private static class SingletonHolder
		{
			internal static readonly VeryLazySingleton _instance = new VeryLazySingleton();
		}

		private VeryLazySingleton()
		{
			Console.WriteLine("VeryLazySingleton is getting instantiated");
		}

		public static VeryLazySingleton Instance
		{
			get
			{
				return SingletonHolder._instance;
			}
		}

		// calling this method won't instantiate singleton
		public static void DoSomething()
		{
			Console.WriteLine("VeryLazySingleton is Doing something");
		}
	}

	public class LazySimplifiedSingleton
	{
		private static readonly Lazy<LazySimplifiedSingleton> _instance = new Lazy<LazySimplifiedSingleton>( () => new LazySimplifiedSingleton(), true);

		private LazySimplifiedSingleton()
		{
			Console.WriteLine("LazySimplifiedSingleton is getting instantiated");
		}

		public static LazySimplifiedSingleton Instance
		{
			get
			{
				return _instance.Value;
			}
		}

		public static void DoSomething()
		{
			Console.WriteLine("LazySimplifiedSingleton is Doing something");
		}
	}


}
