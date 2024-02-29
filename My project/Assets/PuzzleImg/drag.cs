using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{
    public GameObject pos;
    public GameObject detector;
    Vector3 pos_awal;
    // Start is called before the first frame update
    void Start()
    {
        pos_awal= transform.position;
        
    }

    void OnMouseDrag()
    {
        Vector3 pos_mouse=Camera.main.ScreenToWorldPoint (new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
        transform.position = new Vector3(pos_mouse.x, pos_mouse.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
