using System.Collections;
using UnityEngine;

public class WanderingAI : MonoBehaviour
{
    private bool _alive;

    public float speed = 3.0f;
    public float obsstacleRange = 5.0f;

    void Start()
    {
        _alive = true;
    }

    void Update()
    {
        if (_alive)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);

            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;

            if (Physics.SphereCast(ray, 0.75f, out hit))
            {
                if (hit.distance < obsstacleRange)
                {
                    float angle = Random.Range(-110, 110);
                    transform.Rotate(0, angle, 0);
                }
            }
        }
    }

    public void SetAlive(bool alive)
    {
        _alive = alive;
    }
}
