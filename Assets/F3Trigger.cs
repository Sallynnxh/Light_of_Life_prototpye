using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F3Trigger : MonoBehaviour
{
    public GameObject Tube3;
    public GameObject Floor3;
    public GameObject Tube4;
    public GameObject Floor4;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // ����ײ�����������ʱ
        {
            Tube3.SetActive(true); // ����tube
            Floor3.SetActive(true); // ����floor
            Tube4.SetActive(true); // ����tube
            Floor4.SetActive(true); // ����floor
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
