namespace LEARNING_CONCEPTS
{
	public class LEARNING_CONCEPTS_TESTER
	{
		public void SomeFunction()
		{
			Dtx.SomeClass2 someClass2 = new Dtx.SomeClass2();

			// Note: SomeClass3 is not accessable!
			//Dtx.SomeClass3 someClass3 = new Dtx.SomeClass3();

			// Note: SomeClass41 is not accessable!
			//Dtx.SomeClass4.SomeClass41 someClass41 = new Dtx.SomeClass4.SomeClass41();

			Dtx.SomeClass4.SomeClass42 someClass42 = new Dtx.SomeClass4.SomeClass42();

			// Note: SomeClass43 is not accessable!
			//Dtx.SomeClass4.SomeClass43 someClass43 = new Dtx.SomeClass4.SomeClass43();

			// Note: SomeClass5 is not accessable!
			//Dtx.SomeClass5.SomeClass51 someClass51 = new Dtx.SomeClass5.SomeClass51();
			//Dtx.SomeClass5.SomeClass52 someClass52 = new Dtx.SomeClass5.SomeClass52();
			//Dtx.SomeClass5.SomeClass53 someClass53 = new Dtx.SomeClass5.SomeClass53();

			Dtx.SomeClass6 someClass6 = new Dtx.SomeClass6();

			someClass6.A = 10;

			// Note: B Property is not Accessable!
			//someClass6.B = 20;

			// Note: C Property is not Accessable!
			//someClass6.C = 30;

			// Note: D Property is not Accessable!
			//someClass6.D = 40;

			// Note: E Property is not Accessable!
			//someClass6.E = 50;
		}
	}

	public class SomeClass8 : Dtx.SomeClass6
	{
		public void SomeFunction2()
		{
			A = 10;

			// Note: B Property is not Accessable!
			//B = 20;

			C = 30;

			// Note: D Property is not Accessable!
			//D = 40;

			E = 50;
		}
	}
}
