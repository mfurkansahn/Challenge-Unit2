using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    [SerializeField]
    float fireDelay = 10.0f;

    // Update is called once per frame
    void Update()
    {
        fireDelay -= 0.2f;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && fireDelay <= 0f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            fireDelay = 10.0f;
        }
    }
}
