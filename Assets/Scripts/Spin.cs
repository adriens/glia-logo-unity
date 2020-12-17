using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.5f;
    private float y = 0f;
    private void FixedUpdate() {
        transform.rotation = Quaternion.Euler(0, y, 0);
        y+=speed;
    }
}
