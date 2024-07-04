using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManagerInterface : MonoBehaviour
{
	[SerializeField] private int count = 0;
	[SerializeField] bool dontDestroy = true;
	private static GameManagerInterface _instance;
	protected void Awake()
	{
		InstanceGameObject();
		count++;
	}

	public void InstanceGameObject()
	{
		if (_instance == null)
		{
			_instance = this as GameManagerInterface;
			if (dontDestroy)
				DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}

	void Start()
	{
		// Your initialization code here
	}

	void Update()
	{
		// Your update code here
	}
}
