namespace goldenxp
{
	using UnityEngine;
	using UnityEngine.Events;
	
	[AddComponentMenu("STAC/Actions/Play (Legacy) Animation Action")]
	[HelpURL(Utils.HelpURL + "PlayAnimationAction")]
	public class PlayAnimationAction : SimpleActionBase
	{
		public Animation anim;
		public string clipName;
		[Tooltip("Whether to finish prior animations first")]
		public bool queue;
		
		public override void Run()
		{
			if (queue)
				anim.CrossFadeQueued(clipName);
			else
				anim.CrossFade(clipName);
		}
	}
}
