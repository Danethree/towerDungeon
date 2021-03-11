using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Enemy
{
    public class EnemyVision : MonoBehaviour
{
    [SerializeField]Pirsuiter pirsuiterScript;
    void Start()
    {
        pirsuiterScript = transform.GetComponentInChildren<Pirsuiter>();
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player"))
        {
            pirsuiterScript.PirsuitPlayer();
        }
    }
      private void OnTriggerStay2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player"))
        {
            pirsuiterScript.PirsuitPlayer();
        }
    }
}

}
