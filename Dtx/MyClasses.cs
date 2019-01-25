namespace Dtx
{
	public class DtxTester : object
	{
		public DtxTester() : base()
		{
		}

		public void SomeFunction()
		{
			SomeClass2 someClass2 = new SomeClass2();
			SomeClass3 someClass3 = new SomeClass3();

			// Note: SomeClass41 is not accessable!
			//SomeClass4.SomeClass41 someClass41 = new SomeClass4.SomeClass41();

			SomeClass4.SomeClass42 someClass42 = new SomeClass4.SomeClass42();
			SomeClass4.SomeClass43 someClass43 = new SomeClass4.SomeClass43();

			// Note: SomeClass51 is not accessable!
			//SomeClass5.SomeClass51 someClass51 = new SomeClass5.SomeClass51();

			SomeClass5.SomeClass52 someClass52 = new SomeClass5.SomeClass52();
			SomeClass5.SomeClass53 someClass53 = new SomeClass5.SomeClass53();

			SomeClass6 someClass6 = new SomeClass6();

			someClass6.A = 10;

			// Note: B Property is not Accessable!
			//someClass6.B = 20;

			// Note: C Property is not Accessable!
			//someClass6.C = 30;

			someClass6.D = 40;
			someClass6.E = 50;
		}
	}

	// Note: Wrong Usage!
	//private class SomeClass : object
	//{
	//	public SomeClass() : base()
	//	{
	//	}
	//}

	public class SomeClass2 : object
	{
		public SomeClass2() : base()
		{
		}
	}

	internal class SomeClass3 : object
	{
		public SomeClass3() : base()
		{
		}
	}

	// Note: Wrong Usage!
	//protected class SomeClass : object
	//{
	//	public SomeClass() : base()
	//	{
	//	}
	//}

	// Note: Wrong Usage!
	//protected internal class SomeClass : object
	//{
	//	public SomeClass() : base()
	//	{
	//	}
	//}

	public class SomeClass4 : object
	{
		private class SomeClass41 : object
		{
			public SomeClass41() : base()
			{
			}
		}

		public class SomeClass42 : object
		{
			public SomeClass42() : base()
			{
			}
		}

		internal class SomeClass43 : object
		{
			public SomeClass43() : base()
			{
			}
		}

		protected class SomeClass44 : object
		{
			public SomeClass44() : base()
			{
			}
		}

		protected internal class SomeClass45 : object
		{
			public SomeClass45() : base()
			{
			}
		}

		public SomeClass4() : base()
		{
		}
	}

	internal class SomeClass5 : object
	{
		private class SomeClass51 : object
		{
			public SomeClass51() : base()
			{
			}
		}

		public class SomeClass52 : object
		{
			public SomeClass52() : base()
			{
			}
		}

		internal class SomeClass53 : object
		{
			public SomeClass53() : base()
			{
			}
		}

		protected class SomeClass54 : object
		{
			public SomeClass54() : base()
			{
			}
		}

		protected internal class SomeClass55 : object
		{
			public SomeClass55() : base()
			{
			}
		}

		public SomeClass5() : base()
		{
		}
	}

	public class SomeClass6 : object
	{
		public SomeClass6() : base()
		{
		}

		public int A;
		private int B;
		protected int C;

		// می‌باشد private می‌باشد و در خارج پروژه جاری public در پروژه جاری
		internal int D;

		// می‌باشد protected می‌باشد و در خارج پروژه جاری public در پروژه جاری
		protected internal int E;

		public void SomeFunction1()
		{
			A = 10;
			B = 20;
			C = 30;
			D = 40;
			E = 50;
		}
	}

	public class SomeClass7 : SomeClass6
	{
		public SomeClass7() : base()
		{
		}

		public void SomeFunction2()
		{
			A = 10;

			// Note: B Property is not Accessable!
			//B = 20;

			C = 30;
			D = 40;
			E = 50;
		}
	}
}
