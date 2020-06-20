using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionCtrl : MonoBehaviour
{
    public GameObject winText;
    public GameObject lostText;
    private bool flag = false;
    private void OnCollisionEnter(UnityEngine.Collision hit)
    {
        if(hit.gameObject.name == "Ch09_nonPBR" && !flag)
        {
            flag = true;
            winText.SetActive(true);
            Debug.Log("Win!!!!");
        }
        else if(hit.gameObject.name == "Capsule" && !flag)
        {
            flag = true;
            lostText.SetActive(true);
            Debug.Log("Lose!!!!");
        }
    }
}
