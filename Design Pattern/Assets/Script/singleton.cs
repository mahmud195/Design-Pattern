using UnityEngine;

public class singleton<T> : MonoBehaviour where T : MonoBehaviour
{
	private static T _instance;
	[SerializeField] bool dontDestroy = true;

	protected virtual void Awake()
	{
		InstanceGameObject();
	}

	private void InstanceGameObject()
	{
		if (_instance == null)
		{
			_instance = this as T;
			if (dontDestroy)
				DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}
}
