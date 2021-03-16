using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonVizualizer : MonoBehaviour
{
    
       public GameObject button;
     

    void Start()
    {
        button.SetActive(false);
    }
   void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            button.SetActive(true);
        }
   }

    void OnTriggerExit2D(Collider2D other)
   {
        if(other.gameObject.CompareTag("Player"))
        {
            button.SetActive(false);
        }
   }

}
