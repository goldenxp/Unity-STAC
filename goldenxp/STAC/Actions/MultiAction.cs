namespace goldenxp
{
	using UnityEngine;
	using UnityEngine.Events;
	
	[AddComponentMenu("STAC/Actions/Multi Action")]
	public class MultiAction : SimpleActionBase
	{
		public SimpleActionBase[] actions;
		
		public override void Run()
		{
			foreach (var action in actions)
			{
				action.Run();
			}
		}
	}
}
