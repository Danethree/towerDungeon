using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.WarriorScripts.ScriptableObjects;

namespace Scripts.WarriorScripts
{
    public class AttackPlayer : MonoBehaviour
    {
      
               public PlayerControl playerControlscript;
        void Start()
        {
           playerControlscript = GetComponentInParent<PlayerControl>();
           
        }
        void OnTriggerEnter2D(Collider2D other)
        {
            if(other.gameObject.CompareTag("enemy"))
            {
                other.GetComponent<EnemyLife>().TakeDamage(playerControlscript.myPower);
            }
        }
}

}
