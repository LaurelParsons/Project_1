using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeDudeBehavior : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
