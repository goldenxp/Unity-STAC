namespace goldenxp
{
	using UnityEngine;
	using UnityEngine.Events;
	
	[AddComponentMenu("STAC/Actions/Invoke Custom Event Action")]
	[HelpURL(Utils.HelpURL + "InvokeCustomEventAction")]
	public class InvokeCustomEventAction : SimpleActionBase
	{
		public string eventName;
		
		public override void Run()
		{
			CustomEvents.Instance.Invoke(eventName);
		}
	}
}
