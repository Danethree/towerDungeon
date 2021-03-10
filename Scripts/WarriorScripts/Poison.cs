using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.WarriorScripts;
using UnityEngine.UI;

namespace Scripts.WarriorScripts
{
    public class Poison : MonoBehaviour
    {
        PlayerLife playerLife_script;
        bool isPoisoned;
        SpriteRenderer player_sprite;

        void Start()
        {
            playerLife_script = GetComponent<PlayerLife>();
            player_sprite = GetComponent<SpriteRenderer>();

        }

        IEnumerator poisonPlayer()
        {

            player_sprite.color = new Color(118, 0, 95,255);
            while (isPoisoned)
            {
                yield return new WaitForSeconds(3f);
                playerLife_script.TakeDamage();
            }

        }


        IEnumerator endPoisoned()
        {
            yield return new WaitForSeconds(10f);
            StopCoroutine("poisonPlayer");
            isPoisoned = false;
            player_sprite.color = Color.white;

        }

        void Update()
        {
            if (isPoisoned)
            {
                StartCoroutine("endPoisoned");
            }
        }
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("poison"))
            {
                if (!isPoisoned)
                {
                    isPoisoned = true;
                    StartCoroutine("poisonPlayer");
                }
            }
        }
    }
}

