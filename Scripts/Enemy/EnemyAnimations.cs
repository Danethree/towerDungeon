    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    namespace Scripts.Enemy
    {
            public class EnemyAnimations : MonoBehaviour
        {
            public Animator enemy_animation;
        public GameObject go;
        public Transform player;
            void Start()
            {
                enemy_animation = GetComponent<Animator>();
            }

        public  void enemyWalk(bool walk)
        {
            enemy_animation.SetBool("isWalk",walk);
        }
        }
    }

