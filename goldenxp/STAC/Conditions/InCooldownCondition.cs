namespace goldenxp
{
	using System.Collections;
	using UnityEngine;
	
	[AddComponentMenu("STAC/Conditions/In Cooldown Condition")]
	[HelpURL(Utils.HelpURL + "InCooldownCondition")]
	public class InCooldownCondition : SimpleConditionBase
	{
		public float cooldownTime;
		public bool coolingDown = false;
		
		public override bool Check()
		{
			if (!coolingDown)
			{
				coolingDown = true;
				StartCoroutine(ResetCooldown());
				return false;
			}
			
			return true;
		}
		
		IEnumerator ResetCooldown()
		{
			yield return new WaitForSeconds(cooldownTime);
			coolingDown = false;
		}
	}
}
