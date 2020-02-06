using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHitsGoundDemo : MonoBehaviour
{
    [SerializeField] private AudioClip bang;
    void OnCollisionEnter(Collision collider)
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(bang);
    }

}
