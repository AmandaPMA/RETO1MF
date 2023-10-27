using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Codigo_Final : MonoBehaviour
{
    [SerializeField] int fuerzasalto,fuerzaHorizontal;
    [SerializeField]float movimientoHorizontal, movimientoVertical, alturaRayo;
    [SerializeField] bool estarEnSuelo;
    [SerializeField] LayerMask capaDeSuelo;




    RaycastHit hit;
    Animator animator;
    Rigidbody2D rigidbody;
    SpriteRenderer spriteRenderer;





    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        movimientoHorizontal = Input.GetAxisRaw("Horizontal");
        movimientoVertical = Input.GetAxisRaw("Vertical");

        if (movimientoHorizontal != 0f)
        {
            transform.position += Vector3.right * movimientoHorizontal * Time.deltaTime;
            animator.SetBool("Correr", true);
        }
        else
        {
            animator.SetBool("Correr", false);
        }


     
        Debug.DrawRay(transform.position, Vector2.down * alturaRayo, Color.red, 0.01f);
        if (Physics2D.Raycast(transform.position, Vector2.down, alturaRayo, capaDeSuelo))
        {

            Debug.Log("Tocando Piso");
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                animator.SetTrigger("Saltar");
                rigidbody.velocity = Vector2.up * fuerzasalto;
                Debug.Log("Salta");

            }
        }
        else { Debug.Log("NO Tocando Piso"); }


    }
}
