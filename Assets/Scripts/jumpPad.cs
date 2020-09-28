using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class jumpPad : MonoBehaviour {
 
     public int speed;
 
     void OnCollisionEnter(Collision other)
     {
         if (other.gameObject.CompareTag("JumpPad"))
         {
             other.gameObject.GetComponent<Rigidbody>
                     ().AddForce(Vector3.up*speed);
         }
     }
 }
