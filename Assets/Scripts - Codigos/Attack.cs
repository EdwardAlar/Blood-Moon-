using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] private Transform ControladorGolpe;
    [SerializeField] private float radioGolpe;

    [SerializeField] private float dañoGolpe;

    [SerializeField] private float tiempoEntreAtaques;

    [SerializeField] private float tiempoSiguienteAtaque;
    private Animator animator;


    private void Start()
    {
        animator = GetComponent<Animator>();
    }


    private void Update() 
    {

        if(tiempoSiguienteAtaque > 0)
        {
            tiempoSiguienteAtaque -= Time.deltaTime;
        }
        if(Input.GetButtonDown("Fire1") && tiempoSiguienteAtaque <= 0)
        {
            Golpe();
            tiempoSiguienteAtaque=tiempoEntreAtaques;
        }
    }

    private void Golpe()
    {

        animator.SetTrigger("Golpe");
        Collider2D[] objetos = Physics2D.OverlapCircleAll(ControladorGolpe.position, radioGolpe);

        foreach (Collider2D Colisionador in objetos)
        {
            if(Colisionador.CompareTag("Enemigo"))
            {
                Colisionador.transform.GetComponent<Enemigo>().TomarDaño(dañoGolpe);
            }
        }
    }




    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(ControladorGolpe.position, radioGolpe);
    }
}
