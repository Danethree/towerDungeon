using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.WarriorScripts.PlayerArrow;
//using UnityStandardAssets.CrossPlatformInput;
using Scripts.WarriorScripts.ScriptableObjects;
using Scripts;
  //This Script is responsable for control Player Inputs

namespace Scripts.WarriorScripts
{
  
    public class PlayerControl : MonoBehaviour,IPlayer
{
    public AudioSource attackFx;
   public GameObject archer,warrior,mage,firePrefab,arrowPrefab;
 [HideInInspector] public GameObject player;
   public Transform spawnPos;
   Rigidbody2D warrior_rb;
   float dirX;
   [HideInInspector]public float moveSpeed = 10f;
   public PlayerAnimations playerAnimationsScript;
   public bool isAttack;
        [HideInInspector] public float attackRate =1f;
 
     [HideInInspector]  public bool flipX;
    public PlayerSO player_scriptable;
    public int myPower;
   private void Start() {
         myPower = player_scriptable.power;
        player = this.gameObject;
       warrior_rb = GetComponent<Rigidbody2D>();
     
       
     
   } 
   private void Update() {

           // IdlePosition();
           //  PCMovement();

        }

    private void IdlePosition()
        {
            if (warrior_rb.velocity == Vector2.zero)
            {
                playerAnimationsScript.StateMovement(0);
            }

        }
        private void Flip()
        {
            if(flipX)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
        }

   public void MoveUp()
   {
           
            playerAnimationsScript.StateMovement(1);
            Flip();
            transform.position+=Vector3.up*moveSpeed*Time.deltaTime;
   }
    public void MoveDown()
    {
          
            playerAnimationsScript.StateMovement(2);
            Flip();
            transform.position+=Vector3.down*moveSpeed*Time.deltaTime;
    }
    public void MoveLeft()
    {

          transform.localScale = new Vector3(-1,1,1);
            flipX = true;
          playerAnimationsScript.StateMovement(3);
     
         transform.position+=Vector3.left*moveSpeed*Time.deltaTime;
    }
    public void MoveRight()
    {
        
        transform.localScale = new Vector3(1,1,1);
            flipX = false;
             playerAnimationsScript.StateMovement(4);
         transform.position+=Vector3.right*moveSpeed*Time.deltaTime;
    }
    public void SimpleAttack()
    {
      
        if(!isAttack)
        {
              SoundManager.instance.PlayAttackFx(attackFx);
            playerAnimationsScript.Attack();
            if(archer.activeSelf)
            {
                 StartCoroutine("InvokeArrow");
                  
            }
            else if(warrior.activeSelf)
            {
                StartCoroutine("warriorAttackRate");
            }
        
        }
         
           
    }

    public IEnumerator InvokeArrow()
    {
          isAttack = true;
        GameObject arrowTemp =  Instantiate(arrowPrefab,spawnPos.position,Quaternion.identity) as GameObject;
        arrowTemp.transform.localScale = transform.localScale;
                if(flipX)
                {
                    arrowTemp.GetComponent<Arrow>().VerifyArrowPosition(Vector2.left);
                }
                else if(!flipX)
                {
                     arrowTemp.GetComponent<Arrow>().VerifyArrowPosition(Vector2.right);
                }
                  
               
                 Destroy(arrowTemp,3f);
                 yield return new WaitForSeconds(attackRate);
                 isAttack = false;
            
    }

    IEnumerator warriorAttackRate()
    {
        isAttack = true;
        yield return new WaitForSeconds(attackRate);
        isAttack = false;
    }
 

    public void PCMovement()
        {
            IdlePosition();
            if(Input.GetKeyDown(KeyCode.Space))
            {
                SimpleAttack();
            }
            if(Input.GetKey(KeyCode.UpArrow))
            {
              
                MoveUp();
            }
             if (Input.GetKey(KeyCode.DownArrow))
            {
              
                MoveDown();
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {

                MoveLeft();
            }
            if(Input.GetKey(KeyCode.RightArrow))
            {
                MoveRight();
            }
           
        }
     //ARROW 


}



}
