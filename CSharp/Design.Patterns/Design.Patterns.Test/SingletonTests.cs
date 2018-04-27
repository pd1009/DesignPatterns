using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Design.Patterns.Singleton;

namespace Design.Patterns.Test
{
	[TestClass]
	public class SingletonTests
	{
		[TestMethod]
		public void TestThreadUnsafeSingleton()
		{
			SingletonThreadUnsafe threadUnsafe1 = SingletonThreadUnsafe.GetInstance();

			SingletonThreadUnsafe threadUnsafe2 = SingletonThreadUnsafe.GetInstance();

			Assert.AreSame(threadUnsafe1, threadUnsafe2);
		}

		[TestMethod]
		public void TestThreadSafeSingleton()
		{
			SingletonThreadSafe threadSafe1 = SingletonThreadSafe.GetInstance();

			SingletonThreadSafe threadSafe2 = SingletonThreadSafe.GetInstance();

			Assert.AreSame(threadSafe1, threadSafe2);
		}


		[TestMethod]
		public void TestSingletonRealWorld()
		{
			Console.WriteLine("Start of test singleton real world");
			SingletonRealWorld realWorld1 = SingletonRealWorld.Instance;

			SingletonRealWorld realWorld2 = SingletonRealWorld.Instance;

			realWorld1.DoSomething();


			Assert.AreSame(realWorld1, realWorld2);
		}

		[TestMethod]
		public void TestLazySingleton()
		{
			Console.WriteLine("Start of test lazy singleton");
			LazySingleton.DoSomething();
			LazySingleton lazySingleton1 = LazySingleton.Instance;

			LazySingleton lazySingleton2 = LazySingleton.Instance;


			Assert.AreSame(lazySingleton1, lazySingleton2);
		}


		[TestMethod]
		public void TestVeryLazySingleton()
		{
			Console.WriteLine("Start of test  verylazy singleton");
			VeryLazySingleton.DoSomething();

			VeryLazySingleton veryLazySingleton1 = VeryLazySingleton.Instance;

			VeryLazySingleton veryLazySingleton2 = VeryLazySingleton.Instance;


			Assert.AreSame(veryLazySingleton1, veryLazySingleton2);
		}

		[TestMethod]
		public void TestLazySimplifiedSingleton()
		{
			Console.WriteLine("Start of test  lazy simplified singleton");
			LazySimplifiedSingleton.DoSomething();

			LazySimplifiedSingleton lazySimplifiedSingleton1 = LazySimplifiedSingleton.Instance;

			LazySimplifiedSingleton lazySimplifiedSingleton2 = LazySimplifiedSingleton.Instance;


			Assert.AreSame(lazySimplifiedSingleton1, lazySimplifiedSingleton2);
		}
	}
}
