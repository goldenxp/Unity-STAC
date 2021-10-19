namespace goldenxp
{
	using UnityEngine;
	using UnityEngine.Events;
	
	[AddComponentMenu("STAC/Actions/Destroy Action")]
	[HelpURL(Utils.HelpURL + "DestroyAction")]
	public class DestroyAction : SimpleActionBase
	{
		[Tooltip("GameObject(s) that will be destroyed.")]
		public GameObject[] gameObjects;
		
		public override void Run()
		{
			foreach (GameObject item in gameObjects)
			{
				Destroy(item);
			}
		}
	}
}
