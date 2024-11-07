using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] Topmovement playerScript;

    private void Start()
    {
        playerScript = GetComponent<Topmovement>();
    }
    
    void Update()
    {      
        if (playerScript.caught == true)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }

    }
}
