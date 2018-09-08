using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attachable : MonoBehaviour
{
    public Transform connector;

    public void AttachTo(Attachable other)
    {
        // Align connector rotations
        var deltaRotation = other.connector.rotation * Quaternion.Inverse(this.connector.rotation);
        this.transform.rotation = deltaRotation * this.transform.rotation;

        // Align connector positions
        var displacement = other.connector.position - this.connector.position;
        this.transform.position += displacement;

        // parenting
        this.transform.parent = other.transform.parent;
    }
}