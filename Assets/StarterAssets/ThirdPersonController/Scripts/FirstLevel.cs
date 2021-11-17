using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLevel : MonoBehaviour
{
    public GameObject platform;
    public Vector3 axeUp = new Vector3(0,5,0);
    public bool lift = false;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if(lift){
            platform.transform.Translate(Vector3.up);
            lift = false;
        }
    }
    void OnTriggerEnter(Collider collider){
        if (collider.gameObject.name == "PlayerArmature"){
            Debug.Log("Hit");
            lift = true;
        }

    }
}
