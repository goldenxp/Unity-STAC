namespace goldenxp
{
	using UnityEngine;
	using UnityEngine.InputSystem;
	
	[AddComponentMenu("STAC/Triggers/Trigger (Collider) Trigger")]
	public class TriggerEventsTrigger : SimpleTriggerBase
	{
		public SimpleActionBase actionEnter;
		public SimpleActionBase actionExit;
		public SimpleActionBase actionStay;
		public ColliderTagCondition condition;
		
		protected void OnTriggerEnter(Collider other)
		{
			if (CheckColliderCondition(other))
				actionEnter.Run();
		}
		
		protected void OnTriggerExit(Collider other)
		{
			if (CheckColliderCondition(other))
				actionEnter.Run();
		}
		
		protected void OnTriggerStay(Collider other)
		{
			if (CheckColliderCondition(other))
				actionEnter.Run();
		}
		
		protected bool CheckColliderCondition(Collider collider)
		{
			if (condition != null)
			{
				condition.SetTestCollider(collider);
				return condition.Check();
			}
			
			return true;
		}
	}
}