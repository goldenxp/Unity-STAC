namespace goldenxp
{
	using UnityEngine;
	using UnityEngine.Events;
	
	[AddComponentMenu("STAC/Actions/Play Audio Action")]
	[HelpURL("https://github.com/goldenxp/Unity-STAC/wiki/PlayAudioAction")]
	public class PlayAudioAction : SimpleActionBase
	{
		[Tooltip("Audio Source that will be played.")]
		public AudioSource source;
		[Tooltip("If provided, the Action randomly picks a clip from the list for the Audio Source.")]
		public AudioClip[] clips;
		
		public override void Run()
		{
			if (clips != null && clips.Length > 0)
			{
				source.clip = clips[Random.Range(0, clips.Length)];
			}
			
			source.Play();
		}
	}
}
