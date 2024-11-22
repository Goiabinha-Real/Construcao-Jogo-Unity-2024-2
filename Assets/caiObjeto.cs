using System.Collections;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

public class caiObjeto : MonoBehaviour
{
    public Transform finalPos, platformPos;
    public Rigidbody objeto;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player")){
            StartCoroutine(Wait3());
        }
    }
    IEnumerator Wait3()
    { 
    objeto.useGravity = true;
    yield return new WaitForSeconds(3);
    objeto.useGravity = false;
    }

}
