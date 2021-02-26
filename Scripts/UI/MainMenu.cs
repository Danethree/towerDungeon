using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

  public GameObject mainPanel; 
  public Text informationTxt;
   int whichPlayerIsOn = 1;
 
  private void Start() {
      mainPanel.SetActive(false);
      
  }
  public void TouchScreen()
   {
       mainPanel.SetActive(true);
   
       informationTxt.enabled = false;
   }
   private void Update() {
     
   }


   public void SwitchCharacter()
   {
       switch(whichPlayerIsOn)
       {
           case 1:
                PlayerPrefs.SetInt("CHARACTER",1);
                
                break;
           case 2:
                 PlayerPrefs.SetInt("CHARACTER",2);
                break; 
       }
   }

}
