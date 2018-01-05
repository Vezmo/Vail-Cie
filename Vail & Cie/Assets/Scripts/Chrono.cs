using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chrono : MonoBehaviour {
    public int Speed;
    public int LeftDirection;
    public int RightDirection;
    public int UpDirection;
    public int DownDirection;


    Animator animator;

	// Use this for initialization
	void Start ()
    {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Moveleft released
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animator.SetBool("Left", false);
        }

        //Moveright released
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.SetBool("Right", false);
        }

        //MoveUp released
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            animator.SetBool("Up", false);
        }

        //Movedown released
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            animator.SetBool("Down", false);
        }

        //Left Movement
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Moveleft
            transform.position = new Vector2(transform.position.x + LeftDirection * Speed * Time.deltaTime, transform.position.y);
            animator.SetBool("Left", true);
        }
        //Right Movement
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //MoveRight
            transform.position = new Vector2(transform.position.x + RightDirection * Speed * Time.deltaTime, transform.position.y);
            animator.SetBool("Right", true);
        }
        //Up Movement
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //MoveUp
            transform.position = new Vector2(transform.position.x , transform.position.y + UpDirection *Speed * Time.deltaTime);
            animator.SetBool("Up", true);
        }
        //Down Movement
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //MoveDown
            transform.position = new Vector2(transform.position.x , transform.position.y + DownDirection * Speed * Time.deltaTime);
            animator.SetBool("Down", true);
        }
    }
}
