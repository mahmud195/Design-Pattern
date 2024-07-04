using Unity.VisualScripting;
using UnityEngine;

public class GameManager : singleton<GameManager>
{
	[SerializeField] private int count = 0;

	protected override void Awake()
	{
		base.Awake();
		count++;
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
