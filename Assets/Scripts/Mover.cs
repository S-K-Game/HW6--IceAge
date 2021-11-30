using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component moves its object when the player clicks the arrow keys.
 */
public class Mover: MonoBehaviour {
       [Tooltip("step size in meters")] [SerializeField] float stepSize = 1f;
       [SerializeField] KeyCode upKey, downKey, leftKey, rightKey;
       [SerializeField] private float Speed = 1f;
        public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
      animator= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()

    {  
        if(Input.GetKey(leftKey)){
            transform.position += new Vector3(-stepSize * Time.deltaTime, 0, 0);
            animator.SetFloat("Speed", Speed);
        } else if(Input.GetKey(rightKey)){
            transform.position += new Vector3(stepSize * Time.deltaTime, 0, 0);
            animator.SetFloat("Speed", Speed);
        } else if(Input.GetKey(downKey)){
            transform.position += new Vector3(0, -stepSize * Time.deltaTime, 0);
            animator.SetFloat("Speed", Speed);
        }else if(Input.GetKey(upKey)){
            transform.position += new Vector3(0, stepSize * Time.deltaTime, 0);
            animator.SetFloat("Speed", Speed);
        }else{
            animator.SetFloat("Speed", 0f);
        }
        
    }
}