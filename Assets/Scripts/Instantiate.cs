using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject Ball;
    public float force;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject parent = GameObject.Find("InstantiatePoint");

        if (Input.GetMouseButtonDown(0))
        {
            GameObject ball = Instantiate(Ball, parent.transform.position, Quaternion.identity);

            ball.transform.parent = parent.transform;

            ball.gameObject.GetComponent<Rigidbody>().AddForce(0, 0, force);
        }

    }
}
