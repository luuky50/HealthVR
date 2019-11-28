using UnityEngine;

namespace UniFix
{
	/// <summary> MADE BY: Mathias Bevers
	/// When there should only be one instance of a class it can inherit from Singleton.
	/// </summary>
	/// <typeparam name="T">The class that should be a Singleton</typeparam>
	public abstract class Singleton<T> : MonoBehaviourExtra where T : Singleton<T>
	{
		/// <summary>
		/// When this is true and the Singleton is not set up correctly,
		/// All the references to the Instance will attempt to find an object with this Singleton class.
		/// </summary>
		public static bool SearchForInstance { get; set; } = true;

		/// <summary>
		/// Returns the Singleton Instance of the requested class type.
		/// When no Instance is found, there will be an attempt to find a instance in the scene.
		/// In case there are more then one instances found, an error is thrown and null will be returned.
		/// </summary>
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
				}

				Instance = newInstance;

				return instance;
			}
			set
			{
				instance = value;
			}
		}

		/// <summary>
		/// Returns the Instance if it is initialized.
		/// </summary>
		public static T InstanceIfInitialized => IsInitialized ? Instance : null;

		/// <summary>
		/// Returns whether if the instance is initialized or not.
		/// </summary>
		public static bool IsInitialized => instance != null;

		/// <summary>
		/// The Awake method, called by Unity when the MonoBehaviour is initialized, sets up the Singleton's unique Instance. 
		/// All classes that inherit from Singleton should call base.Awake() to make sure that the Instance is set up propperly.
		/// </summary>
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

		/// <summary>
		/// The OnDestroy method, called by Unity when the MonoBehaviour is destroyed, makes sure the unique instance is also destroyed and set to null.
		/// All classes that inherit from Singleton should call base.OnDestroy() to make sure the instance is cleaned op prop[perly.
		/// </summary>
		protected virtual void OnDestroy()
		{
			if (instance == this)
			{
				instance = null;
			}
		}
	}
}