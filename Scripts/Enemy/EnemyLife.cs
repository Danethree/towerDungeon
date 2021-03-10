using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enemy.EnemyScriptableObjects;
using Scripts.WarriorScripts.ScriptableObjects;
public class EnemyLife : MonoBehaviour
{
  
    public EnemySO enemy_scriptable;
    public SpriteRenderer enemy_sprite;
    bool damaged;
    public float life,strenght;
 

     Transform player;
   
    void Start()
    {
        enemy_sprite = GetComponent<SpriteRenderer>();
        life = enemy_scriptable.life;
        
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
      
    }


    void Update()
    {
       
        VerifyLoseCondition();
    }

   public float TakeDamage(float damagePower)
    {
       StartCoroutine("BlinkEnemy");
       
        life -= damagePower;
        damaged = false;
        Debug.Log("VIDA INIMIGO"+life);
        return life;
    }
    IEnumerator BlinkEnemy()
    {
          enemy_sprite.color = Color.red;
          yield return new WaitForSeconds(.1f);
          enemy_sprite.color = Color.white;
        
    }
   

    void VerifyLoseCondition()
    {
        if(life<=0)
        {
            Destroy(gameObject);
        }
    }
   
    

}
