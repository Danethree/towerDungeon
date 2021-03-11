using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scripts.UI
{
    public class CreditsUI : MonoBehaviour
{

  
   public void Back()
   {
       SceneManager.LoadScene("titleMenu");
   }
 
}
}

