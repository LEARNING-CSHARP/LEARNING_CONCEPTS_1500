namespace Dtx
{
	public class DtxTester
	{
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
	//private class SomeClass1
	//{
	//}

	public class SomeClass2
	{
	}

	internal class SomeClass3
	{
	}

	public class SomeClass4
	{
		private class SomeClass41
		{
		}

		public class SomeClass42
		{
		}

		internal class SomeClass43
		{
		}
	}

	internal class SomeClass5
	{
		private class SomeClass51
		{
		}

		public class SomeClass52
		{
		}

		internal class SomeClass53
		{
		}
	}

	public class SomeClass6
	{
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
