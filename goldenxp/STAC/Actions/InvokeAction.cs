namespace goldenxp
{
	using UnityEngine;
	using UnityEngine.Events;
	
	[AddComponentMenu("STAC/Actions/Invoke Unity Event Action")]
	[HelpURL("https://github.com/goldenxp/Unity-STAC/wiki/InvokeAction")]
	public class InvokeAction : SimpleActionBase
	{
		public UnityEvent events;
		
		public override void Run()
		{
			events.Invoke();
		}
	}
}
