using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PIckup : MonoBehaviour
{
    public GameObject SmashEffect;

    void OnMouseDown(GameObject)
    {
        Destroy(GameObject);
        Instantiate(SmashEffect, transform.position, Quaternion.identity);
    }
}
