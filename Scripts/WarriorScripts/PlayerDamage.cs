using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    namespace Scripts.WarriorScripts
    {
        public class PlayerDamage : MonoBehaviour
    {
        PlayerLife playerLife_script;
        void Start()
        {
            playerLife_script = GetComponentInParent<PlayerLife>();
        }

       void OnCollisionEnter2D(Collision2D other) {
           if(other.gameObject.CompareTag("enemy"))
           {
               playerLife_script.TakeDamage();
           }
       }
    }

    }
