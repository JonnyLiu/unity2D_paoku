using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
	public int Hp=1;
    private Rigidbody2D rBoby;
	private bool isGround = false;
	private Animator ani;

	// Use this for initialization
	void Start () {
		rBoby = GetComponent<Rigidbody2D>();
		ani = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//跳跃
	public void Jump()
	{
		if(isGround == true && Hp>0){
      //给一个力
	  rBoby.AddForce(Vector2.up * 400);
	  AudioManager.Instance.PlaySound("跳");
		}
	}

	//发生碰撞
    private void OnCollisionEnter2D(Collision2D collision)
	{
		//如果碰撞地面
		if (collision.collider.tag=="Ground")
		{
			isGround = true;
			//结束跳跃动画
		    ani.SetBool("Jump",false);
		}

	}
	//结束碰撞
	private void OnCollisionExit2D(Collision2D collision)
	{
		//如果离开地面
		if (collision.collider.tag=="Ground")
		{
			isGround = false;
			//播放跳跃动画
		    ani.SetBool("Jump",true);
		}

	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		//碰撞到敌人
		if (collision.tag =="Enemy" && Hp>0)
		{
			Hp--;
			if(Hp<=0)
			{
				ani.SetBool("Die",true);
				AudioManager.Instance.PlaySound("Boss死了");
				Destroy(rBoby);
			}
		}

	}

}
