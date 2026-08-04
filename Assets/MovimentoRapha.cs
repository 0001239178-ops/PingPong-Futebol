using UnityEngine;

public class MovimentoRapha : MonoBehaviour
{



    [Header("Ajustes De Jogabilidade")]
    [Range(1f, 10f)]
    public float sensibilidade = 7f;
    public bool jogador1;

    private Rigidbody2D rb;
    private float moveY;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (jogador1)
        {
            moveY = Input.GetAxisRaw("Vertical");

        }
        else
        {
            moveY = Input.GetAxisRaw("Vertical2");
        }

    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(0f, moveY * sensibilidade);
    }

}
