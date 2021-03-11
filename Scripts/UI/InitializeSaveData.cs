using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts.UI
{
        public class InitializeSaveData : MonoBehaviour
    {
        int points,coins;
       public Text pointsTxt,coinsTxt;
        void Start()
        {
            points = PlayerPrefs.GetInt("POINTSRECORD");
            coins = PlayerPrefs.GetInt("COINSRECORD");
           

            pointsTxt.text = points.ToString();
            coinsTxt.text = coins.ToString();
        }

        

    }

}
