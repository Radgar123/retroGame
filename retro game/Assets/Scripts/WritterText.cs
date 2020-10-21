using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

public class WritterText : MonoBehaviour
{
    [SerializeField]  private float pause = 0.2f;
    public string message;
    public Text messageText;

    // Start is called before the first frame update
    void Start()
    {
        messageText.text = "";
        StartCoroutine(TextTyping());
    }

    IEnumerator TextTyping() 
    {
        foreach (char letter in message.ToCharArray()) 
        {
            messageText.text += letter;
            yield return new WaitForSeconds(pause);
        }
    }
}
