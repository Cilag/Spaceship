using UnityEngine;

public class AsteroideSpawner : MonoBehaviour
{
    public GameObject asteroids;
    public float tempsInitialAvantDebutGeneration = 2f;
    public float intervalleMinGeneration = 0.5f;
    public float reductionIntervalle = 0.05f;
    public float vitesseMin = 3f;
    public float vitesseMax = 7f;
    public int nombreMaxAsteroide = 10;
    private float tempsEcoule = 0f;
    private float tempsTotal = 0f;

    void Update()
    {
        tempsEcoule += Time.deltaTime;
        tempsTotal += Time.deltaTime;

        // Calculer l'intervalle de génération en fonction du temps total écoulé
        float intervalleGeneration = Mathf.Max(intervalleMinGeneration, tempsInitialAvantDebutGeneration - tempsTotal * reductionIntervalle);

        // Générer un astéroïde à intervalles réguliers
        if (tempsEcoule > intervalleGeneration)
        {
            GenererAsteroide();
            tempsEcoule = 0f;  // Réinitialiser le temps écoulé
        }
    }

    void GenererAsteroide()
    {
        // Créer un astéroïde à une position aléatoire sur toute la largeur de l'écran
        float xPosition = Random.Range(Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x, Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x);
        Vector3 positionGenerateur = new Vector3(xPosition, Camera.main.orthographicSize + 1f, 0f);

        GameObject nouvelAsteroide = Instantiate(asteroids, positionGenerateur, Quaternion.identity);

        float vitesseAleatoire = Random.Range(vitesseMin, vitesseMax);

        // Ajouter une force vers le bas pour simuler le mouvement
        nouvelAsteroide.transform.Translate(Vector3.down * vitesseAleatoire * Time.deltaTime);
    }
}
