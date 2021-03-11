using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonVizualizer : MonoBehaviour
{
    
    public GameObject buttonChest;


    void Start()
    {
        buttonChest.SetActive(false);
    }
   void OnTriggerEnter2D(Collider2D other)
   {
       if(other.gameObject.CompareTag("Player"))
       {
           buttonChest.SetActive(true);
       }
   }

    void OnTriggerExit2D(Collider2D other)
   {
       if(other.gameObject.CompareTag("Player"))
       {
           buttonChest.SetActive(false);
       }
   }

}
