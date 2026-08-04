using UnityEngine;

public class SistemaOxigenioCurto : MonoBehaviour
{
    public float vida = 100f, oxigenio = 100f;
    public bool naAgua;

    void Update()
    {
        if (naAgua)
        {
            // Se tem ar, gasta. Se não tem, tira vida.
            if (oxigenio > 0) oxigenio -= 10f * Time.deltaTime;
            else vida -= 15f * Time.deltaTime;
        }
        else if (oxigenio < 100f)
        {
            // Fora da água, recupera o ar rápido
            oxigenio += 25f * Time.deltaTime;
        }

        if (vida <= 0) Debug.Log("Morreu afogado!");
    }
}  