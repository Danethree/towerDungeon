using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Scripts.UI
{
      public class PowerUpUI : MonoBehaviour
    {
      
       public GameObject slow_img,fast_img,poison_img,force_img;
        void Start()
        {
            
        }

       
        void Update()
        {
          
        }

        public void ActiveFeedbackPowerUp(GameObject powerObj,bool activated)
        {
            powerObj.SetActive(activated);
        }
    }


}
  
