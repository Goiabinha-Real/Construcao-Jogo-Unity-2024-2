using System.Collections;
using UnityEngine;

public class ResetPlatform : MonoBehaviour
{
    public Transform finalPos, platformPos;
    public GameObject platform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            StartCoroutine(Wait2());
        }
    }
    IEnumerator Wait2()
    {   
    yield return new WaitForSeconds(1);
    platform.GetComponent<Rigidbody>().useGravity = false;
    yield return new WaitForSeconds(0.5f);
    platform.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
    platform.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    platformPos.position = finalPos.position;
    }

}
