using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    public float vitesse = 5f;

    void Update()
    {
        // Déplacer l'astéroïde vers le bas
        transform.Translate(Vector3.down * vitesse * Time.deltaTime);

        // Vérifier si l'astéroïde est sorti de l'écran
        if (transform.position.y < -10f)
        {
            // Détruire l'astéroïde
            Destroy(gameObject);
        }
    }
}
