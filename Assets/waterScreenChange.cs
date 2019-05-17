using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterScreenChange : MonoBehaviour {

   
    
   // private bool inwater = false;
    //private bool outwater = true;
  
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" )
        {
           // inwater = true;
           // outwater = false;
            Debug.Log("enter");
            RenderSettings.fog = true;

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" )
        {
           // inwater = false;
           // outwater = true;
            Debug.Log("exits");
            RenderSettings.fog = false;

        }
    }
}
