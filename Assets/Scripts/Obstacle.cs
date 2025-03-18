using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public Parallax.Layer layer;
    public float destroyObject = -8.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Parallax.GetSpeed(layer) * Time.deltaTime;
        if (transform.position.x > destroyObject)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Health.TryDamageTarget(other.gameObject, 1);
    }
}
