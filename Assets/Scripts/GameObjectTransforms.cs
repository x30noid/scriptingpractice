using UnityEngine;

public class GameObjectTransforms : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Position Codes

        //transform.position = new Vector3(1, 1, 1);

        //Rotation Codes

        //transform.Rotate(new Vector3(0,1,0));
        //transform.localEulerAngles = new Vector3(0, 90, 0);

        //Scale Codes

        //transform.localScale = new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        //Position Codes

        //transform.position += new Vector3(1 * speed, 0, 0);

        //transform.position += transform.up * speed;

        //transform.Translate(0, 1 * speed, 0);

        //Rotation Codes

        //transform.Rotate(0, 1, 0);

        //transform.localEulerAngles += new Vector3(0, 1 * speed, 0);

        //Scale Codes

        transform.localScale += new Vector3(0, 1 * speed, 0);
    }
}
