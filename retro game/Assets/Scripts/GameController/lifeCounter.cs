using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lifeCounter : MonoBehaviour
{
    public static int heart;

     private Text life = null;

    // Start is called before the first frame update
    void Start()
    {
        heart = 3;
        life = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        life.text = "" + heart;
    }
}
