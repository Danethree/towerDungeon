using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Objects
{

    public class Chest : MonoBehaviour
    {
    ChestAnimations chestAnimations;
    public GameObject enemyPrefab;
    public GameObject[] powerUpPrefab;
    int randomic,randomicPositions;
   public Transform spawnPosition;
    void Start() {
        chestAnimations = GetComponent<ChestAnimations>();
      
    }
    
    public void OpenTreasureChest()
    {

        chestAnimations.OpenChest();
        randomic = Random.Range(0,40);
        if(randomic >=0 && randomic <=10)
        {
            GameObject newEnemy = Instantiate(enemyPrefab,spawnPosition.position,Quaternion.identity) as GameObject;
        }
        else if(randomic>10 && randomic<=30)
        {
            randomicPositions = Random.Range(0,3);
              GameObject newEnemy = Instantiate(enemyPrefab,spawnPosition.position,Quaternion.identity) as GameObject;
        }
        
        else if(randomic>30 && randomic<=40)
        {
            GameObject newVelocityPrefab = Instantiate(powerUpPrefab[randomicPositions],spawnPosition.position,Quaternion.identity) as GameObject;
        }

        Destroy(gameObject);

    }

    }

}