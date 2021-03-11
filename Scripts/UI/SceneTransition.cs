using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scripts.UI
{
    public class SceneTransition : MonoBehaviour
{
    public int time;
 
    void Update()
    {
         StartCoroutine("LoadScene");
    }
    public IEnumerator LoadScene()
    {
       
        yield return new WaitForSeconds(time);
         SceneManager.LoadScene("titleMenu");

    } 
}

}
