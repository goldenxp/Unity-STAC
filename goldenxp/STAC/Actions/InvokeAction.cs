namespace goldenxp
{
	using UnityEngine;
	using UnityEngine.Events;
	
	[AddComponentMenu("STAC/Actions/Invoke Unity Event Action")]
	[HelpURL(Utils.HelpURL + "InvokeAction")]
	public class InvokeAction : SimpleActionBase
	{
		public UnityEvent events;
		
		public override void Run()
		{
			events.Invoke();
		}
	}
}
