using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float vitesseDeplacement = 7f;
    public float limiteXMin = -9f;
    public float limiteXMax = 9f;
    public float limiteYMin = -5f;
    public float limiteYMax = 4f;

    void Update()
    {
        float deplacementHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * deplacementHorizontal * vitesseDeplacement * Time.deltaTime);

        float deplacementVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * deplacementVertical * vitesseDeplacement * Time.deltaTime);

        float nouvellePositionX = Mathf.Clamp(transform.position.x, limiteXMin, limiteXMax);
        float nouvellePositionY = Mathf.Clamp(transform.position.y, limiteYMin, limiteYMax);

        transform.position = new Vector3(nouvellePositionX, nouvellePositionY, transform.position.z);
    }
}
