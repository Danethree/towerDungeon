using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.WarriorScripts;
using Scripts.WarriorScripts.PlayerEnumerators;
using UnityEngine.SceneManagement;

namespace Scripts
{
    public class GameManager : MonoBehaviour
{

      public GameObject warrior,archer;
      public GameState gameState;
      public static GameManager instance;


    private void Awake() {
      if(instance == null)
      {
        instance = this;
      }
      
      DontDestroyOnLoad(instance);
    }
    void Start()
    {
      
      
      
    }

   
    void Update()
    {
        
    }



     void InitializePlayer()
    {
      warrior.SetActive(false);
      archer.SetActive(false);
      if(PlayerPrefs.GetInt("CHARACTER") == 1)
      {
           warrior.SetActive(true);
      }
      else if(PlayerPrefs.GetInt("CHARACTER") == 2)
      {
          archer.SetActive(true);        
      }
    }

   public void GameOver()
    {
      gameState = GameState.endGame;
      if(gameState == GameState.endGame)
      {
        SceneManager.LoadScene("GameOver");
       
      }
    }
   public void GameOverOptions()
    {
          
         SceneManager.LoadScene("SelectionPanel");
    
    }
    public void GameOn()
    {
         gameState = GameState.playing;
           InitializePlayer();
    }
}

}
