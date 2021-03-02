using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class InitializeChar : MonoBehaviour
    {
        int id;
        public GameObject warrior, archer;

        void Awake()
        {
            id = PlayerPrefs.GetInt("CHARACTER");
            if (id == 1)
            {
                Debug.Log("id:"+id);
                warrior.SetActive(true);
                archer.SetActive(false);
            }
            else
            {
                Debug.Log("id:" + id);
                archer.SetActive(true);
                warrior.SetActive(false);
            }
        }
        void Start()
        {
            
        }

        
        void Update()
        {

        }
    }
}

