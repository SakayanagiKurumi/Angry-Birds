using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class BlackBird : Bird
{
    [SerializeField]

    public GameObject explosionEffect;

   // public override void OnTap()
    void OntriggerEnter2D()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}