using UnityEditor.IMGUI.Controls;
using UnityEngine;

public class caiObjeto : MonoBehaviour
{
    public GameObject objeto;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player")){
            objeto.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
