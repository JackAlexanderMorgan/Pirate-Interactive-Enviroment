using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerDVD : MonoBehaviour
{
    [SerializeField] private Animator myDVD = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                myDVD.Play("DVD open", 0, 0.0f);
                
            }

            else if (closeTrigger)
            {
                myDVD.Play("DVD Close", 0, 0.0f);
                
            }
        }
    }
}
