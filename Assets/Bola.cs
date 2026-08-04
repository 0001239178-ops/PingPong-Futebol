using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;


public class Bola : MonoBehaviour
{
    [Header("Ajustes de jogabilidade")]
    public float velocidade = 2f;
    private Rigidbody2D rb;
    private Vector2 posicaoInicial;
    private float velocidadeGiro = 2f;

    [Header("Efeitos gráficos")]
    public GameObject efeitoFaisca;

    [Header("Efeitos de som")]
    public AudioClip somGol;
    public AudioClip somPerigo;
    public AudioClip somRebater1;
    public AudioClip somRebater2;

    private AudioSource caixaDeSom;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        caixaDeSom = GetComponent<AudioSource>();

        posicaoInicial = transform.position;
        Launch();
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.linearVelocity = new Vector2(velocidade * x, velocidade * y);
        float direcaoGiro = Random.Range(0, 2) == 0 ? -1f : 1f;
        rb.angularVelocity = velocidadeGiro * direcaoGiro * direcaoGiro;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        caixaDeSom.PlayOneShot(somRebater2);
        Vector2 novaVelocidade = rb.linearVelocity;
        novaVelocidade *= 1.05f;
        rb.linearVelocity = novaVelocidade;

        GameObject novaFaisca = Instantiate(efeitoFaisca, transform.position, Quaternion.identity);
        Destroy(novaFaisca, 1f);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("GolEsq") || (other.CompareTag("GolDir")))

            {
            caixaDeSom.PlayOneShot(somGol);
            ResetarBola();


            }
          
                
        
    }

    void ResetarBola()
    {
        rb.linearVelocity = Vector2.zero;
        transform.position = posicaoInicial;
        Invoke("Launch", 1f);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
