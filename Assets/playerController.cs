using UnityEngine;

public class playerController : MonoBehaviour
{
    public float velocidade = 5f;
    public float velRot = 10f;
    public float forcaSalto = 1f;
    public float alturaSalto = 0f;
    public float alturaMax = 1.5f;
    public float ccgravidade = 0.5f;
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController cc;
    private bool pulando = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cc = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxisRaw("Horizontal") * Time.deltaTime*velRot;
        float vert = Input.GetAxisRaw("Vertical") * Time.deltaTime*velocidade;
        if (cc.isGrounded){
            moveDirection = new Vector3(0, 0,vert);
            moveDirection = transform.TransformDirection(moveDirection);
        }
        if (pulando==true && transform.localPosition.y<alturaSalto){
            moveDirection.y += forcaSalto * Time.deltaTime;
        }
        else{
            moveDirection.y -= ccgravidade *Time.deltaTime;
            pulando = false;
        }
        cc.Move(moveDirection);
        transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
        if (Input.GetKeyDown(KeyCode.Space) && cc.isGrounded)
        {
            alturaSalto = transform.localPosition.y+alturaMax;
            pulando = true;
        }
    }
}
