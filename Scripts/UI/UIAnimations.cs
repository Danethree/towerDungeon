using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.UI
{
    public class UIAnimations : MonoBehaviour
{
    public GameObject warrior,archer;
   
     Animator ui_anim;

    void Start() {
        ui_anim = GetComponent<Animator>();
    }
    public void FinalizeMovement(bool finalize)
    {
        ui_anim.SetBool("finalize",finalize);
    }
   
  

}

}
