using UnityEngine;

public class RelojController : MonoBehaviour
{
    public Transform minutero;
    public Transform horario;

    public float velocidadMinuto = 100f;
    public float velocidadHora = 10f;

    void Update()
    {
        if (minutero != null)
        {
            minutero.Rotate(0, 0, -velocidadMinuto * Time.deltaTime);
        }

        if (horario != null)
        {
            horario.Rotate(0, 0, -velocidadHora * Time.deltaTime);
        }
    }
}