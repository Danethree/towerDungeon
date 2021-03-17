using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.WarriorScripts
{
    public class PowerUp : MonoBehaviour
{
     
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
         
            gameObject.SetActive(false);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}

}
