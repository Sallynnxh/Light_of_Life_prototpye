using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path2Spirit : MonoBehaviour
{
    public GameObject Tube1;
    public GameObject Spirit;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // ����ײ�����������ʱ
        {
            Tube1.SetActive(true); // ����tube
            Spirit.SetActive(true); // ����floor
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
