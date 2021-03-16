

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using Scripts;

namespace Scripts.UI
{
    public class CharacterChoose : MonoBehaviour
{
    
   public GameObject warriorbutton,archerbutton,magebutton,archer,warrior,mage;
   
   public UIAnimations anim_warrior,anim_archer,anim_mage;
   public UICutscene uiCutscene_script;
    int i = 0;
      int previous,next;
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

   public void MageBtn()
   {
      
         Debug.Log("MAGE SELECTED!");
         PlayerPrefs.SetInt("CHARACTER",3);
         mage.SetActive(true);
         anim_mage.FinalizeMovement(true);
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
         magebutton.SetActive(true);
         mage.SetActive(true);
      }
      else if(magebutton.activeSelf)
      {
         magebutton.SetActive(false);
         mage.SetActive(false);
         warriorbutton.SetActive(true);
         warrior.SetActive(true);
      }
     
    

   }

   public void GameScene()
   {
         SceneManager.LoadScene("game");

   }
   
}
}

