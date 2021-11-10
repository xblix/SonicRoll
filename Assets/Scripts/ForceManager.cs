using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// La classe ForceManager permet de manipuler la force du GameObject sur lequel le script est plac�
public class ForceManager : MonoBehaviour
{
    // On d�clare nos attributs
    // On veut manipuler la force du GameObject. Seule solution : appeler la classe Rigidbody
    // La variable reste priv�e car on ne la manipule que dans la pr�sente classe
    private Rigidbody rb;

    // La variable vitesse est d�clar�e publique pour pouvoir la manipuler sepuis l'�diteur Unity
    public float speed;

    // On initie nos variables
    void Awake()
    {
        // rb est instanci� en prenant comme valeur celles du Rigidbody associ� au pr�sent GameObject
        rb = GetComponent<Rigidbody>();

        // On initie notre variable vitesse de type float � 10
        speed = 10f;
}

    // Ajouter une force � un gameobject � chaque fixedFrame
    private void FixedUpdate()
    {
        // On r�cup�re les valeurs de nos Input et on les stocke dans des variables de type float
        // Ces variables contiennent donc une valeur pour se diriger sur un axe horizontal ou vertical
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // On cr�� un vecteur Vector3 contenant les variables sur les axes X et Z r�cup�r�s pr�c�demment
        // L'axe Y vertical ne peut pas �tre modifi� par ces variables, donc on laisse sa valeur � 0
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        // On fait appel � la m�thode AddForce de la classe Rigidbody pour "pousser" notre objet
        // RigidBody est assign� � notre GameObject pour �tre influenc� par la gravit�
        // On multiplie le vecteur par une vitesse
        rb.AddForce(movement * speed);
    }





}
