using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	//如果有人进入触发区域
    private void OnTriggerEnter2D(Collider2D collison)
	{
		if (collison.tag == "Player")
		{
			AudioManager.Instance.PlaySound("金币");
			Destroy(gameObject);
		}
	}

}
