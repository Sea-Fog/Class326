using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using UnityEngine;

public class Excercise2 : MonoBehaviour
{
    [SerializeField] private ForceMode forceMode;
    [SerializeField] private float amplitude;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space)) rb.AddForce(Vector3.up * amplitude,forceMode);
    }
}
