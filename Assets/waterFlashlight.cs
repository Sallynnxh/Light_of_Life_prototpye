using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterFlashlight : MonoBehaviour
{
    public GameObject liquidWater; 
    public GameObject frozenWater;
    public GameObject light;
    public GameObject iceCubeAfter;
    public GameObject iceCubeBefore;

        private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            liquidWater.SetActive(false);
            frozenWater.SetActive(true);
            light.SetActive(true);
            iceCubeBefore.SetActive(false);
            iceCubeAfter.SetActive(true);
        }
    }
}
