

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Scripts;
public class CharacterChoose : MonoBehaviour
{
    
   public GameObject warrior,archer;
   public UIAnimations anim_warrior,anim_archer;
   public UICutscene uiCutscene_script;
   public void WarriorBtn()
   {
       Debug.Log("WARRIOR SELECTED!");
        PlayerPrefs.SetInt("CHARACTER",1);
         uiCutscene_script.panel.SetActive(false);
        anim_warrior.FinalizeMovement(true);
       // GameManager.instance.GameOn();
      
       Invoke("GameScene",2f);
   }
   public void ArcherBtn()
   {
         Debug.Log("ARCHER SELECTED!");
         PlayerPrefs.SetInt("CHARACTER",2);
            uiCutscene_script.panel.SetActive(false);
         anim_archer.FinalizeMovement(true);
         //   GameManager.instance.GameOn();
             Invoke("GameScene",2f);
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

   public void btnNext()
   {
      if(warrior.activeSelf)
      {
         warrior.SetActive(false);
         archer.SetActive(true);
         
      }
      else if(archer.activeSelf)
      {
         archer.SetActive(false);
         warrior.SetActive(true);
      }

   }

   public void GameScene()
   {
         SceneManager.LoadScene("game");

   }
   
}
