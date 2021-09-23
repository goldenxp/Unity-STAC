namespace goldenxp
{
	using UnityEngine;
	using UnityEngine.Events;
	
	[AddComponentMenu("STAC/Conditions/Raycast Hit Condition")]
	public class RaycastHitCondition : SimpleConditionBase
	{
		public Transform caster;
		public Vector3 direction = Vector3.forward;
		public float distance = Mathf.Infinity;
		public LayerMask layers;
		[Space]
		public RaycastHit ray;
		public Vector3 hitPoint;
		
		public override bool Check()
		{
			hitPoint = Vector3.zero;
			if (Physics.Raycast(caster.position, 
				caster.TransformDirection(direction),
				out ray, distance, layers))
			{
				hitPoint = ray.point;
				return true;
			}
			
			return false;
		}
	}
}
