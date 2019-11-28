using UnityEngine;

namespace UniFix
{
	/// <summary> MADE BY: Mathias Bevers
	/// There are some functions that should be, in my opinion, in MonoBehaviour that aren't.
	/// Now scripts can inherit from MonoBehaviourExtra to have access to the extra functions.
	/// </summary>
	public class MonoBehaviourExtra : MonoBehaviour
	{
		/// <summary> 
		/// Unity's build in "transform" gets the transform-component every time.
		/// CachedTransform only does that once and stores it in a variable you can access.
		/// </summary>
		private Transform cachedTransform = null;
		public Transform CachedTransform
		{
			get
			{
				if (cachedTransform == null)
				{
					cachedTransform = transform;
				}

				return cachedTransform;
			}
		}

		/// <summary>
		/// CachedRectTransform gets the CachedTransform as RectTransform.
		/// </summary>
		public RectTransform CachedRectTransform => CachedTransform as RectTransform;

		/// <summary>
		/// While looping through all the children, they get destroyed.
		/// </summary>
		public void DestroyChilderen()
		{
			foreach (Transform child in CachedTransform)
			{
				Destroy(child);
			}
		}

		/// <typeparam name="TComponent">The compnent that needs to be checked. It has to inherit from compnent</typeparam>
		/// <returns>Returns true if it has "TComponent"</returns>
		public bool HasComponent<TComponent>() where TComponent : Component
		{
			TComponent component = GetComponent<TComponent>();

			if (component == null)
			{
				return false;
			}

			return true;
		}

		/// <typeparam name="TComponent">The component that is requested. It has to inherit from compnent</typeparam>
		/// <returns>TCompent if it exists</returns>
		public TComponent GetComponentIfInitialized<TComponent>() where TComponent : Component
		{
			TComponent component = GetComponent<TComponent>();

			if (component == null)
			{
				throw new NoComponentFoundException(typeof(TComponent).Name);
			}

			return component;
		}

		/// <summary>
		/// When an component is absolutely necessary EnsureComonent make sure that the component exists.
		/// </summary>
		/// <typeparam name="TComponent">The requested compnent</typeparam>
		public void EnsureComponent<TComponent>() where TComponent : Component
		{
			TComponent component = GetComponent<TComponent>();

			if (component != null)
			{
				return;
			}

			gameObject.AddComponent<TComponent>();
		}
	}
}