using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.WarriorScripts
{
    public class SpeedPowerUp : MonoBehaviour
{
    PlayerControl playerControl_script;  
    public float previousPower,powerSpeed,previusAttackRate,speedAttackRate;
   
    float currentPower, time,currentAttack;
    bool isSlow,isFast;
    SpriteRenderer playerSprite;

    void Start()
    {
         

        powerSpeed = 5;
            speedAttackRate = 2;
        playerControl_script = GetComponent<PlayerControl>();
        previousPower = playerControl_script.moveSpeed;
        previusAttackRate = playerControl_script.attackRate;
        isSlow = false;
        isFast = false;
        playerSprite = GetComponent<SpriteRenderer>();
    }  
    void Update()
    {

            SlowAndFastCondition();
    }
        void SlowAndFastCondition()
        {
            if (isSlow)
            {
                if (isFast)
                {
                    isFast = false;
                  playerSprite.color = Color.Lerp(Color.red,Color.white,Mathf.PingPong(2*Time.time,.5f));
                }
                  playerSprite.color = Color.Lerp(Color.red,Color.white,Mathf.PingPong(2*Time.time,.5f));
            }

            else if (isFast)
            {
                if (isSlow)
                {
                    isSlow = false;
                       playerSprite.color = Color.Lerp(Color.blue,Color.white,Mathf.PingPong(2*Time.time,.5f));
                }
                   playerSprite.color = Color.Lerp(Color.blue,Color.white,Mathf.PingPong(2*Time.time,.5f));

            }
        }

    void OnTriggerEnter2D(Collider2D other)
    {
     
        if(other.gameObject.CompareTag("speedUp"))
        {
               if(!isFast)
            {
                    
                    StartCoroutine("PowerUpSpeed");
            }
           
        }
        else if(other.gameObject.CompareTag("speedDown"))
        {
           if(!isSlow)
           {
               StartCoroutine("PowerDownSpeed");
           }
        }
    }


    
public IEnumerator PowerUpSpeed()
{
    isFast = true;
           
            currentPower = playerControl_script.moveSpeed + powerSpeed;
    playerControl_script.moveSpeed = currentPower;
            currentAttack = 0.1f;
            playerControl_script.attackRate = currentAttack;
        Debug.Log("Speed com power"+playerControl_script.moveSpeed);
            yield return new WaitForSeconds(10f);
            playerSprite.color = Color.white;
            isFast = false;
            playerControl_script.moveSpeed = previousPower;
            playerControl_script.attackRate = previusAttackRate;
            
         Debug.Log("Voltou ao normal: "+playerControl_script.moveSpeed);
    
}
public IEnumerator PowerDownSpeed()
{
    isSlow = true;
           
            currentPower = playerControl_script.moveSpeed - powerSpeed;
    playerControl_script.moveSpeed = currentPower;
    currentAttack = 2f;
            playerControl_script.attackRate = currentAttack;
 
    yield return new WaitForSeconds(10f);
            playerSprite.color = Color.white;
    isSlow = false;
    playerControl_script.moveSpeed = previousPower;
    playerControl_script.attackRate = previusAttackRate;
    Debug.Log("Voltou ao normal"+playerControl_script.moveSpeed);

    
}


}


}

