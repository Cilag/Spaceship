using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "asteroids" || collision.gameObject.name == "asteroids(Clone)" )
        {
            HandleCollision();
        }
    }
    void HandleCollision()
    {
        // Le joueur a été touché par un astéroïde, afficher le menu ou faire d'autres actions
        SceneManager.LoadScene("MenuScene");
    }
}
