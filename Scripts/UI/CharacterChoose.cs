

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Scripts;
public class CharacterChoose : MonoBehaviour
{
    
    
   public void WarriorBtn()
   {
       Debug.Log("WARRIOR SELECTED!");
        PlayerPrefs.SetInt("CHARACTER",1);
       // GameManager.instance.GameOn();
        SceneManager.LoadScene("game");

   }
   public void ArcherBtn()
   {
         Debug.Log("ARCHER SELECTED!");
         PlayerPrefs.SetInt("CHARACTER",2);
         //   GameManager.instance.GameOn();
            SceneManager.LoadScene("game");
   }
   private void Update() {
      if(Input.GetButtonDown("Fire2"))
      {
         WarriorBtn();
      }
      if(Input.GetButtonDown("Fire3"))
      {
         ArcherBtn();
      }
   }
}
