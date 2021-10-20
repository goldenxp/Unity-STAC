namespace goldenxp
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.Playables;
	using UnityEngine.Animations;
	
	[RequireComponent(typeof(Animator))]
	public class PlayableMixer : MonoBehaviour
	{
		private PlayableGraph graph;
		private AnimationMixerPlayable mixer;
		private AnimationClipPlayable clipPlay;
		
		private const int input_ctrl = 0;
		private const int input_clip = 1;
		private const int input_count = 2;
		
		protected void Start()
	    {
		    // Make the graph with a mixer that can mix the animator controller and requested clips
		    graph = PlayableGraph.Create();
		    mixer = AnimationMixerPlayable.Create(graph, input_count);
		    var animator = GetComponent<Animator>();
		    var output = AnimationPlayableOutput.Create(graph, "Animation", animator);
		    output.SetSourcePlayable(mixer);
		    
		    var playable = AnimatorControllerPlayable.Create(graph, animator.runtimeAnimatorController);
		    graph.Connect(playable, 0, mixer, input_ctrl);
		    graph.Play();
	    }
	    
		protected void OnDestroy()
		{
			graph.Destroy();
		}
	    
		public void PlayClip(AnimationClip clip)
		{
			if (!clipPlay.IsNull())
			{
				graph.Disconnect(mixer, input_clip);
			}
			
			clipPlay = AnimationClipPlayable.Create(graph, clip);
			clipPlay.SetTime(0.0);
			clipPlay.SetDuration(clip.length);
			
			graph.Connect(clipPlay, 0, mixer, input_clip);
			mixer.SetInputWeight(1, input_clip);
			mixer.SetInputWeight(0, input_ctrl);
		}
		
		protected void Update()
		{
			if (!clipPlay.IsNull() && clipPlay.IsDone())
			{
				mixer.SetInputWeight(0, input_clip);
				mixer.SetInputWeight(1, input_ctrl);
			}
		}
	}
}