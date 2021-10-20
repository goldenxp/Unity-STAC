namespace goldenxp
{
	using UnityEngine;
	
	[AddComponentMenu("STAC/Actions/Runners/Multi Action")]
	[HelpURL(Utils.HelpURL + "MultiAction")]
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
