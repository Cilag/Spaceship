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

        // Calculer l'intervalle de g�n�ration en fonction du temps total �coul�
        float intervalleGeneration = Mathf.Max(intervalleMinGeneration, tempsInitialAvantDebutGeneration - tempsTotal * reductionIntervalle);

        // G�n�rer un ast�ro�de � intervalles r�guliers
        if (tempsEcoule > intervalleGeneration)
        {
            GenererAsteroide();
            tempsEcoule = 0f;  // R�initialiser le temps �coul�
        }
    }

    void GenererAsteroide()
    {
        // Cr�er un ast�ro�de � une position al�atoire sur toute la largeur de l'�cran
        float xPosition = Random.Range(Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x, Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x);
        Vector3 positionGenerateur = new Vector3(xPosition, Camera.main.orthographicSize + 1f, 0f);

        GameObject nouvelAsteroide = Instantiate(asteroids, positionGenerateur, Quaternion.identity);

        float vitesseAleatoire = Random.Range(vitesseMin, vitesseMax);

        // Ajouter une force vers le bas pour simuler le mouvement
        nouvelAsteroide.transform.Translate(Vector3.down * vitesseAleatoire * Time.deltaTime);
    }
}
