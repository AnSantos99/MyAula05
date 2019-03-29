using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behave : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("MEEEEOW!");
        transform.localScale = new Vector3 (3, 3, 3);
    }

    

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = new Vector3(0.5f, 0.5f, 0.5f);
        transform.Rotate(rot);
    }
}
