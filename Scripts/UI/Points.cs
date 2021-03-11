using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Enemy.EnemyEnums;
using Enemy.EnemyScriptableObjects;
public class Points : MonoBehaviour
{
     int pointsNbr,record;
   [HideInInspector]public Text pointsTxt;
    public EnemySO enemy_scriptable;
    void Start()
    {
        pointsTxt = GameObject.Find("pointsTxt").GetComponent<Text>();
        record = PlayerPrefs.GetInt("POINTSRECORD");
    }

   public void AddRewardPoints()
    {
        if(enemy_scriptable.enemy_classification == EnemyClassification.snake)
        {
            pointsNbr +=5;
            pointsTxt.text = pointsNbr.ToString();
            SavePoints();
        }
         if(enemy_scriptable.enemy_classification == EnemyClassification.skeleton)
        {
            pointsNbr +=10;
            pointsTxt.text = pointsNbr.ToString();
            SavePoints();
        }
    }

    public void SavePoints()
    {
      
        if(record<pointsNbr)
        {
              record = pointsNbr;
              PlayerPrefs.SetInt("POINTSRECORD",record);
        }
    }
}
