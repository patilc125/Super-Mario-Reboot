using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public float speed;
    private Animator animator;

    public AudioSource deathSound,jumpSound;
    public float jump;
    public LayerMask ground;
    private Collider2D playerCollider;
    public LayerMask deathGround;

    public float mileStone;
    private float mileStoneCount;
    private float speedMultipier;
    void Start()
    {
        rigidBody= GetComponent<Rigidbody2D>();
	playerCollider=GetComponent<Collider2D>();
        animator =GetComponent<Animator>();  
        mileStoneCount= mileStone;
    }

   
    void Update()
    {
	bool dead=Physics2D.IsTouchingLayers(playerCollider,deathGround);
	
        if(dead){
            GameOver();
	}


        rigidBody.velocity= new Vector2(speed,rigidBody.velocity.y);
	bool grounded=Physics2D.IsTouchingLayers(playerCollider,ground);
	
        if(Input.GetMouseButtonDown(0)||Input.GetKeyDown(KeyCode.Space)){
                if(grounded){
                jumpSound.Play();
		rigidBody.velocity= new Vector2(rigidBody.velocity.x,jump);
               }
	}
	animator.SetBool("Gounded",grounded);
    }
  void GameOver(){

}
}
