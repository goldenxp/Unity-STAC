namespace goldenxp
{
	using UnityEngine;
	using UnityEngine.Events;
	
	[AddComponentMenu("STAC/Actions/Invoke Unity Event Action")]
	public class InvokeAction : SimpleActionBase
	{
		public UnityEvent events;
		
		public override void Run()
		{
			events.Invoke();
		}
	}
}
