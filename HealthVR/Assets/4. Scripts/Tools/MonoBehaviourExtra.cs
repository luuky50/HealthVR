using UnityEngine;

namespace UniFix
{
	public class MonoBehaviourExtra : MonoBehaviour
	{
		private Transform cachedTransform = null;
		public Transform CachedTransform
		{
			get
			{
				if(cachedTransform == null)
				{
					cachedTransform = transform;
				}

				return cachedTransform;
			}
		}

		public RectTransform CachedRectTransform => CachedTransform as RectTransform;
		
		public bool HasComponent<T>() where T : Component
		{
			T component = GetComponent<T>();

			if(component == null)
			{
				return false;
			}

			return true;
		}

		public T GetComponentIfInitialized<T>() where T : Component
		{
			T component = GetComponent<T>();

			if(component == null)
			{
				throw new NoComponentFoundException(typeof(T).Name);
			}

			return component;
		}

		public void EnsureComponent<T>() where T : Component
		{
			T component = GetComponent<T>();

			if(component != null)
			{
				Debug.Log($"Already has a {typeof(T).Name} component.");
				return;
			}

			Debug.Log($"Adding {typeof(T).Name} component...");
			gameObject.AddComponent<T>();
		}
	}
}