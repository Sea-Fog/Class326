using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    public Transform a;
    public Transform s;
    public Transform d;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) SetTransform(a);
        if (Input.GetKeyDown(KeyCode.S)) SetTransform(s);
        if (Input.GetKeyDown(KeyCode.D)) SetTransform(d);
    }

    void LateUpdate()
    {
        
    }

    void SetTransform(Transform newTransform)
    {
        gameObject.transform.position = newTransform.position;
        gameObject.transform.rotation = newTransform.rotation;

        Debug.Log("Position of cube now at " + newTransform.name);
    }
}
