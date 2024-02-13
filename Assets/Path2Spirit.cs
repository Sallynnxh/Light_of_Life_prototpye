using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path2Spirit : MonoBehaviour
{
    public GameObject Tube1;
    public GameObject Spirit;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // 当碰撞的物体是玩家时
        {
            Tube1.SetActive(true); // 激活tube
            Spirit.SetActive(true); // 激活floor
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
