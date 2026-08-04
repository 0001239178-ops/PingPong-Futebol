using UnityEngine;
using TMPro;
public class PontuacaoJogador : MonoBehaviour
{

    [SerializeField]
    public TextMeshProUGUI placar;
    public GameObject golEsq;
    public GameObject golDir;

    private int ptsJ1;
    private int ptsJ2;

    void Start()
    {
        ptsJ1 = 0;
        ptsJ2 = 0;

        placar.text = (ptsJ1 + " x " + ptsJ2);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag ("GolEsq"))
        {
            ptsJ1++;
            placar.text = (ptsJ1 + " x " + ptsJ2);
        }
        if (other.CompareTag("GolDir"))
        {
            ptsJ2++;
            placar.text = (ptsJ1 + " x " + ptsJ2);
        }

    }





    void Update()
    {
        
    }










}
