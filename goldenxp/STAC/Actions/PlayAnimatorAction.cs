namespace goldenxp
{
	using UnityEngine;
	using UnityEngine.Events;
	using UnityEngine.Playables;
	
	[AddComponentMenu("STAC/Actions/Play Animator Action")]
	[HelpURL(Utils.HelpURL + "PlayAnimatorAction")]
	public class PlayAnimatorAction : SimpleActionBase
	{
		public Animator animator;
		[Header("States")]
		public string stateName;
		
		[Header("Parameters")]
		public string parameterName;
		public AnimatorControllerParameterType parameterType = AnimatorControllerParameterType.Trigger;
		public bool parameterBool;
		public float parameterFloat;
		public int parameterInt;
		
		[Header("Clips (Requires PlayableMixer)")]
		public AnimationClip clip;
		
		public override void Run()
		{
			if (!string.IsNullOrEmpty(stateName))
				animator.Play(stateName);
			
			if (!string.IsNullOrEmpty(parameterName))
			{
				switch (parameterType)
				{
					case AnimatorControllerParameterType.Bool:
						animator.SetBool(parameterName, parameterBool);
						break;
					case AnimatorControllerParameterType.Float:
						animator.SetFloat(parameterName, parameterFloat);
						break;
					case AnimatorControllerParameterType.Int:
						animator.SetInteger(parameterName, parameterInt);
						break;
					case AnimatorControllerParameterType.Trigger:
						animator.SetTrigger(parameterName);
						break;
				}
			} // end param
			
			if (clip != null)
			{
				PlayableMixer mixer = animator.gameObject.GetComponent<PlayableMixer>();
				if (mixer != null)
				{
					mixer.PlayClip(clip);
				}
			}
		}
	}
}
