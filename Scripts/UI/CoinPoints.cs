using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Scripts.UI
{
    public class CoinPoints : MonoBehaviour
    {
    
            int pointCoins,recordPointCoins;
           public Text pointCoinsTxt;
            public AudioSource coinsFx;
           public AudioClip coinClipFx;
         
            void Start()
            {
                pointCoinsTxt = GameObject.FindWithTag("coinIUI").GetComponent<Text>();
                recordPointCoins = PlayerPrefs.GetInt("COINSRECORD");
                pointCoins = PlayerPrefs.GetInt("COINPOINTS");
            }

            void Update()
            {
                
            }
            public void AddPoints()
            {
                pointCoins +=1;
                PlayerPrefs.SetInt("COINPOINTS",pointCoins);
                pointCoinsTxt.text = pointCoins.ToString();
                SavePointsCoins();
            }

            void OnTriggerEnter2D(Collider2D other)
            {
                if(other.gameObject.CompareTag("Player"))
                {
                    SoundManager.instance.PlayGetCoinsFx();
                    AddPoints();
                }
            }

            void SavePointsCoins()
            {
                if(pointCoins>recordPointCoins)
                {
                    recordPointCoins = pointCoins;
                    PlayerPrefs.SetInt("COINSRECORD",recordPointCoins);
                }
            }
    }

}
