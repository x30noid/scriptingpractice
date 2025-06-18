using UnityEngine;

public class GetComponent : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.blue;

        gameObject.GetComponent<Collider>().isTrigger = true;

        GameObject ScriptRef = GameObject.Find("ReferenceScript");

        ScriptRef.GetComponent<GetComponentRef>().Health = 10;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
