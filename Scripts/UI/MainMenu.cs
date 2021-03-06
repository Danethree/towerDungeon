using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

  public GameObject mainPanel; 
   float timeToLoad = 0.5f;
   int whichPlayerIsOn = 1;
 
  private void Start() {
      mainPanel.SetActive(false);
      
  }
  public void LoadChoosePanel()
  {
      SceneManager.LoadScene("ChoosePanel");
  }
  public void LoadCredits()
  {
        SceneManager.LoadScene("Credits");
  }
  public void LoadExit()
  {
       Application.Quit();
  }
  public void PlayButton()
   {
      
       Invoke("LoadChoosePanel",timeToLoad);
     
   }
  public void Credits()
  {
    Invoke("LoadCredits",timeToLoad);
  }
  public void ExitGame()
  {
     Invoke("LoadExit",timeToLoad);
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
