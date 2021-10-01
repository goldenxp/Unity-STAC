namespace goldenxp
{
	using UnityEngine;
	using UnityEngine.Events;
	
	[AddComponentMenu("STAC/Conditions/Pass Once Condition")]
	[HelpURL(Utils.HelpURL + "PassOnceCondition")]
	public class PassOnceCondition : SimpleConditionBase
	{
		private bool passed = false;
		
		public override bool Check()
		{
			if (!passed)
			{
				passed = true;
				return true;
			}
			
			return false;
		}
	}
}
