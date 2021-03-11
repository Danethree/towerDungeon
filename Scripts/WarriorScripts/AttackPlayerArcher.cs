using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Enemy;

namespace Scripts.WarriorScripts
{
        public class AttackPlayerArcher : MonoBehaviour
    {
       
            public PlayerControl playerControlscript;
            void Start()
            {
                playerControlscript = GameObject.Find("Arqueiro").GetComponent<PlayerControl>();
            
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
