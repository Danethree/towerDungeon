using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.WarriorScripts;


public class Poison : MonoBehaviour
{
    PlayerLife playerLife_script;
    bool isPoisoned;
    void Start()
    {
        playerLife_script = GetComponent<PlayerLife>();
    }

    IEnumerator poisonPlayer()
    {
        
        yield return new WaitForSeconds(0.1f);
       
        isPoisoned = false;
 
    }

    void Poisoned()
    {
        isPoisoned = true;
        float time = 1*Time.deltaTime;
         for(int i = 0;i<=2;i++)
        {
            time = time++;
            
        }
         if(time <=0)
        {
            StartCoroutine(poisonPlayer());
        }
    }
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("poison"))
        {
            if(!isPoisoned)
            {
                playerLife_script.TakeDamage();
            }
            
        }
    }
}
