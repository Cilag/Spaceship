using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    public float vitesse = 5f;

    void Update()
    {
        // D�placer l'ast�ro�de vers le bas
        transform.Translate(Vector3.down * vitesse * Time.deltaTime);

        // V�rifier si l'ast�ro�de est sorti de l'�cran
        if (transform.position.y < -10f)
        {
            // D�truire l'ast�ro�de
            Destroy(gameObject);
        }
    }
}
