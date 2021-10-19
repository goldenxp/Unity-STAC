namespace goldenxp
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.Events;

	public class CustomEvents
	{
		protected static CustomEvents instance;
		protected static Dictionary<string, UnityEvent> events = new Dictionary<string, UnityEvent>();
		
		public static CustomEvents Instance
		{
			get
			{
				if (instance == null)
					instance = new CustomEvents();
				
				return instance;
			}
		}
		
		public void Listen(string name, UnityAction action)
		{
			// Add to dictionary if event does not exist
			if (!events.ContainsKey(name))
			{
				events.Add(name, new UnityEvent());
			}
			
			events[name].AddListener(action);
		}
		
		public void Unlisten(string name, UnityAction action)
		{
			// Ignore if event is not in dictionary
			if (!events.ContainsKey(name)) return;
			
			events[name].RemoveListener(action);
		}
		
		public void Invoke(string name)
		{
			// Ignore if event is not in dictionary
			if (!events.ContainsKey(name)) return;
			
			events[name].Invoke();
		}
	}
}
