using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F1Trigger : MonoBehaviour
{
    public GameObject Tube1;
    public GameObject Floor1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // ����ײ�����������ʱ
        {
            Tube1.SetActive(true); // ����tube
            Floor1.SetActive(true); // ����floor
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
