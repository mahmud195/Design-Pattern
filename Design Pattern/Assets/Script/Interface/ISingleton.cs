using UnityEngine;

public interface ISingleton<T> where T : MonoBehaviour
{
	void InstanceGameObject();
	void Awake();
}
