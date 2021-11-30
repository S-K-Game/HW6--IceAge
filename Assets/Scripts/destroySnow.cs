using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroySnow : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] private string triggeringTag = "Axe" ;
 
    private void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == triggeringTag && enabled && (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.E))) {
            Debug.Log("inside trigger");
            Destroy(this.gameObject);
        }
    }
}
