namespace goldenxp
{
	using UnityEngine;
	using UnityEngine.Events;
	
	[AddComponentMenu("STAC/Actions/Able Action")]
	[HelpURL(Utils.HelpURL + "AbleAction")]
	public class AbleAction : SimpleActionBase
	{
		[Tooltip("GameObject(s) that will be enabled or disabled.")]
		public GameObject[] gameObjects;
		[Tooltip("Whether to enable or disable the GameObject(s)")]
		public bool state;
		[Tooltip("If true, it will flip the state after each run. This makes toggling possible.")]
		public bool flipState;
		
		public override void Run()
		{
			foreach (GameObject item in gameObjects)
			{
				item.SetActive(state);
			}
			
			if (flipState)
				state = !state;
		}
	}
}
