namespace goldenxp
{
	using UnityEngine;
	using UnityEngine.InputSystem;
	
	[AddComponentMenu("STAC/Triggers/Custom Events Trigger")]
	[HelpURL(Utils.HelpURL + "CustomEventsTrigger")]
	public class CustomEventsTrigger : SimpleTriggerBase
	{
		public string eventName;
		public SimpleActionBase action;
		
		protected void OnEnable()
		{
			CustomEvents.Instance.Listen(this.eventName, this.Respond);
		}
		
		protected void OnDisable()
		{
			CustomEvents.Instance.Unlisten(this.eventName, this.Respond);
		}
		
		protected void Respond()
		{
			action.Run();
		}
	}
}