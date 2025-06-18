using UnityEngine;

public class FindObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject[] cube  = GameObject.FindGameObjectsWithTag("Player");

        foreach (var item in cube)
        {
            item.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
