using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    [SerializeField]  string scena1;
    [SerializeField] string key;


    public void Update() 
    {
        if (Input.GetKey(key))
        {
            SceneManager.LoadScene(scena1);
            //Time.timeScale = 1f;
            Destroy(GameObject.FindWithTag("gc"));
        }

    }


    public void Play(string scene) 
    {
        StartCoroutine(LoadAfterDelay(scene, 1f));
    }

    public IEnumerator LoadAfterDelay(string scene, float seconds) 
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(scene);
    }

    public void Exit() 
    {
        Application.Quit();
    }
  
}
