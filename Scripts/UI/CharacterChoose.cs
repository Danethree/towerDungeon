

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Scripts;
public class CharacterChoose : MonoBehaviour
{
    
   public GameObject warriorbutton,archerbutton,archer,warrior;
   public UIAnimations anim_warrior,anim_archer;
   public UICutscene uiCutscene_script;
   public void WarriorBtn()
   {
       Debug.Log("WARRIOR SELECTED!");
        PlayerPrefs.SetInt("CHARACTER",1);
       
        anim_warrior.FinalizeMovement(true);
       // GameManager.instance.GameOn();
      
       Invoke("GameScene",2f);
   }
   public void ArcherBtn()
   {
         Debug.Log("ARCHER SELECTED!");
         PlayerPrefs.SetInt("CHARACTER",2);
         archer.SetActive(true);
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
      if(warriorbutton.activeSelf)
      {
         warriorbutton.SetActive(false);//desativa o botao do char
         warrior.SetActive(false);//desativa o char
         archerbutton.SetActive(true);
         archer.SetActive(true);
         
      }
      else if(archerbutton.activeSelf)
      {
         archerbutton.SetActive(false);
         archer.SetActive(false);
         warriorbutton.SetActive(true);
         warrior.SetActive(true);
      }

   }

   public void GameScene()
   {
         SceneManager.LoadScene("game");

   }
   
}
