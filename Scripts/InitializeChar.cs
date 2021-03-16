using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts;
namespace Scripts
{
    public class InitializeChar : MonoBehaviour
    {
        int id;
        public GameObject warrior, archer,mage;
        

        void Awake()
        {
            id = PlayerPrefs.GetInt("CHARACTER");
            if (id == 1)
            {
                Debug.Log("id:"+id);
                warrior.SetActive(true);
                archer.SetActive(false);
                mage.SetActive(false);
            }
            else if(id==2)
            {
                Debug.Log("id:" + id);
                archer.SetActive(true);
                warrior.SetActive(false);
                mage.SetActive(false);
            }
            else if(id==3)
            {
                mage.SetActive(true);
                archer.SetActive(false);
                warrior.SetActive(false);
            }
            
               PlayerPrefs.SetInt("ENEMYPOINTS",0);
            GameManager.instance.gameState = WarriorScripts.PlayerEnumerators.GameState.playing;
         
          
            
        }
        void Start()
        {
               SoundManager.instance.PlayMusicTheme();
        }

        
        void Update()
        {

        }
    }
}

