using UnityEngine;

public class Level2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Cena 2");
    }
}
