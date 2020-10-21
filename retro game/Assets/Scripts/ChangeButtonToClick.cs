using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeButtonToClick : MonoBehaviour
{
    public string sceneName;
    public string keyName;

    [SerializeField] private GameObject turnOn;


    private void Start()
    {
        //turnOn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        turnOn.SetActive(false);
        if (Input.GetKeyDown(keyName)) 
        {
            Destroy(GameObject.FindWithTag("music"));
            Destroy(GameObject.FindWithTag("gc"));
            SceneManager.LoadScene(sceneName);
            PointController.scoreValue = 0;
            ChangeWeapon.Index = 1;
        }
            
    }
}
