namespace goldenxp
{
	using UnityEngine;
	
	[AddComponentMenu("STAC/Actions/Runners/Index Action")]
	[HelpURL(Utils.HelpURL + "IndexAction")]
	public class IndexAction : MultiAction
	{
		public int index;
		
		public override void Run()
		{
			int actionCount = actions.Length;
			if (actionCount == 0 || index > actionCount)
				return;
			
			actions[index].Run();
		}
	}
}
