namespace goldenxp
{
	using UnityEngine;
	using UnityEngine.Events;
	
	[AddComponentMenu("STAC/Conditions/Collider Tag Condition")]
	public class ColliderTagCondition : SimpleConditionBase
	{
		public Collider colliderToTest;
		public string tagToMatch;
		
		public override bool Check()
		{
			if (!string.IsNullOrEmpty(tagToMatch) && colliderToTest.tag == tagToMatch)
				return true;
			
			return false;
		}
		
		public void SetTestCollider(Collider col)
		{
			colliderToTest = col;
		}
	}
}
