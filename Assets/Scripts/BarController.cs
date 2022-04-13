using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody.velocity.y < 0)
        {
            other.attachedRigidbody.velocity = new Vector3(0.0f, 7.0f, 0.0f);
        }
    }
}
