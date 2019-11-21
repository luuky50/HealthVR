using UnityEngine;

namespace UniFix
{
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		public static bool SearchForInstance { get; set; } = true;

		private static T instance = null;
		public static T Instance
		{
			get
			{
				if (IsInitialized)
				{
					return instance;
				}

				T newInstance = null;

				if (SearchForInstance)
				{
					T[] instances = FindObjectsOfType<T>();

					if (instances.Length == 1)
					{
						newInstance = instances[0];
					}
					if (instances.Length > 1)
					{
						Debug.LogError($"Only one of {typeof(T).Name} can be in the scene, there where {instances.Length} found.");
					}
				}

				if (newInstance == null)
				{
					GameObject gameObject = new GameObject()
					{
						hideFlags = HideFlags.HideAndDontSave
					};

					newInstance = gameObject.AddComponent<T>();
				}

				Instance = newInstance;

				return instance;
			}
			set
			{
				instance = value;
			}
		}

		public static bool IsInitialized => instance != null;

		protected virtual void Awake()
		{
			if (!IsInitialized)
			{
				Instance = this as T;
				return;
			}

			if (Instance != this)
			{
				Destroy(this);

				Debug.LogWarning($"Trying to instantiate a second instance of {typeof(T).Name}. Additional instance was destroyed!");
			}
		}

		protected virtual void OnDestroy()
		{
			if (instance == this)
			{
				instance = null;
			}
		}
	}
}