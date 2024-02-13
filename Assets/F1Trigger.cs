using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F1Trigger : MonoBehaviour
{
    public GameObject Tube1;
    public GameObject Floor1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // 当碰撞的物体是玩家时
        {
            Tube1.SetActive(true); // 激活tube
            Floor1.SetActive(true); // 激活floor
        }
    }
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

    }
}
