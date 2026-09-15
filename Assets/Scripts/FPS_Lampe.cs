using UnityEngine;
using UnityEngine.InputSystem; // Utilise la bilibliothèque Input System

public class FPS_Lampe : MonoBehaviour
{
    // ---Initilisation des variables

    [SerializeField] InputAction toggleLampe; //Input pour allumer ou eteindre la lampe
    [SerializeField] GameObject lampe; //Reference de la lampe
    [SerializeField] AudioSource lampeAudio; //Reference de l'audio pour le son de la lampe
    private bool estLampeAllumee = true; //Variable pour savoir si la lampe est allumee ou eteinte (De base est allumee)


    // ---Fonctions

    void OnEnable()
    {
        toggleLampe.Enable(); //Active l'input
    }

    void OnDisable()
    {
        toggleLampe.Disable(); //Desactive l'input
    }

    void Update()
    {
        if (toggleLampe.triggered) //Si l'input est active
        {
            estLampeAllumee = !estLampeAllumee; //Change l'etat de la lampe
            lampe.SetActive(estLampeAllumee); //Active ou desactive la lampe selon l'etat
            lampeAudio.PlayOneShot(lampeAudio.clip); //Joue le son de la lampe
        }
    }
}
