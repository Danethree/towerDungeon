using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

  public GameObject mainPanel; 
 
   int whichPlayerIsOn = 1;
 
  private void Start() {
      mainPanel.SetActive(false);
      
  }
  public void PlayButton()
   {
      SceneManager.LoadScene("ChoosePanel");
   
     
   }
  public void Credits()
  {
      SceneManager.LoadScene("Credits");
  }
  public void ExitGame()
  {
      Application.Quit();
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
