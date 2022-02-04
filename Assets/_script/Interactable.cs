using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//general sript for interaction when player is within range
public class Interactable : MonoBehaviour
{
    public string objectName;
    public Text objectNameText;

    public GameObject inRangeObject; //sets active when in range

    public GameManager gm;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player walks to " + objectName);
            objectNameText.text = objectName;
            inRangeObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player walks to " + objectName);
            objectNameText.text = "";
            inRangeObject.SetActive(false);
        }
    }

    
}
