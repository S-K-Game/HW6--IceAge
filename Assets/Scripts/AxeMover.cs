using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeMover : MonoBehaviour
{
    [SerializeField] KeyCode digKey;
   Animator anim;

    
    void Start()
    {
        anim= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(digKey)){
            anim.SetBool("Swing", true);
        }
        else{
            anim.SetBool("Swing", false);
        }
    }

}
