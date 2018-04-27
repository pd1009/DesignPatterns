using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Singleton
{
	public class SingletonThreadUnsafe
	{
		private static SingletonThreadUnsafe _instance;
		private SingletonThreadUnsafe()
		{
		}

		public static SingletonThreadUnsafe GetInstance()
		{
			// It is not thread safe
			if (_instance == null)
			{
				_instance = new SingletonThreadUnsafe();
			}

			return _instance;
		}
	}

	public class SingletonThreadSafe
	{
		private static SingletonThreadSafe _instance;

		private static readonly object mutex = new object();

		private SingletonThreadSafe()
		{
		}

		public static SingletonThreadSafe GetInstance()
		{
			lock (mutex)
			{
				if (_instance == null)
				{
					_instance = new SingletonThreadSafe();
				}

				return _instance;
			}

		}
	}

	public class SingletonRealWorld
	{
		// If we don't care about when our singleton is getting instatiated then this approach should be fine
		// This does all the overhead of locking, releasing in an optimized way for us
		private static readonly SingletonRealWorld _instance = new SingletonRealWorld();

		private SingletonRealWorld()
		{
			Console.WriteLine("SingletonRealWorld is getting instantiated");
		}

		public static SingletonRealWorld Instance
		{
			get
			{
				return _instance;
			}
		}

		public void DoSomething()
		{
			Console.WriteLine("SingletonRealWorld is Doing something");
		}


	}
}
