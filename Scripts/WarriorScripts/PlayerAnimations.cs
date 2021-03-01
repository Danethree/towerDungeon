using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.WarriorScripts.PlayerEnumerators;

namespace Scripts.WarriorScripts
{
        public class PlayerAnimations : MonoBehaviour
    {
        public Animator player_anim;
        public PlayerState playerState;
        void Start()
        {
            player_anim = GetComponent<Animator>();
        }
       public void StateMovement(int stateP)
        {
             player_anim.SetInteger("state",stateP);
        }
        public void Attack()
        {
            player_anim.SetTrigger("attack");
        }


    }

}
