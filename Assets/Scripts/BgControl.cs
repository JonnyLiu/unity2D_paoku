using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgControl : MonoBehaviour {
	public float Speed = 0.2f;

	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {

		//背景持续滚动
		Vector2 v = transform.localPosition;
		v.x -= Speed * Time.deltaTime;
		//判断如果出了屏幕，就移动到新位置
		if (v.x < -7.2f)
		{
			v.x += 7.2f * 2;

		}
		transform.localPosition=v;
	}
}
