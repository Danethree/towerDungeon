using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Scripts.Objects
{
    public class ChestAnimations : MonoBehaviour
    {
        Animator chest_animator;
        void Start()
        {
            chest_animator = GetComponent<Animator>();
        }

      
       public void OpenChest()
       {
           chest_animator.SetTrigger("open");
       }
    }

}
