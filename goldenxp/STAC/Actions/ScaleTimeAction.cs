namespace goldenxp
{
	using UnityEngine;
	using UnityEngine.Events;
	
	[AddComponentMenu("STAC/Actions/Scale Time Action")]
	[HelpURL(Utils.HelpURL + "ScaleTimeAction")]
	public class ScaleTimeAction : SimpleActionBase
	{
		public float timeScale = 0f;
		[Tooltip("Number of frames to alter the timescale before resetting")]
		public int frames = 30;
		[Tooltip("What to reset the timescale to")]
		public float timeScaleReset = 1.0f;
		
		private int frameCount = -1;
		
		public override void Run()
		{
			Time.timeScale = timeScale;
			frameCount = frames;
		}
		
		protected void Update()
		{
			if (frameCount == -1)
				return;
			
			frameCount--;
			if (frameCount == 0)
			{
				Time.timeScale = timeScaleReset;
				frameCount = -1;
			}
		}
	}
}
