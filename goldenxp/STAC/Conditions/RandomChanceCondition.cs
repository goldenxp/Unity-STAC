namespace goldenxp
{
	using UnityEngine;
	using UnityEngine.Events;
	
	[AddComponentMenu("STAC/Conditions/Random Chance Condition")]
	public class RandomChanceCondition : SimpleConditionBase
	{
		public int odds = 50;
		public int min = 0;
		public int max = 100;
		public CompareOps op = CompareOps.Greater;
		[Space]
		public int roll;
		
		public override bool Check()
		{
			roll = Random.Range(min, max);
			return Utils.Compare(op, roll, odds);
		}
	}
}
