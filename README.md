## 🏓 **PingPong-Futebol** ⚽
> *Um jogo simples de ping pong com o tema da copa do mundo 2026!*

## 📖Informações
* **Engine:** Unity 
* **Linguagem:** C#
  
---

## *Demonstração do Projeto*

| Interface / UI |

<img width="706" height="398" alt="Captura de tela 2026-08-05 135634" src="https://github.com/user-attachments/assets/64013166-94e8-4313-906d-a099d2b98090" />


---

## 🛠️ *Mecânicas e Funcionalidades*

### Já Implementadas:
- [x] Movimentação Do Jogador(Cima/Baixo).
- [x] Audio VFX adicionados.
- [x] Placar da Partida.

### Em Desenolvimento:
- [ ] Personalização De Raquete/Arena/Bola.

---

## ✨ *Trecho De Código em Destaque*

```csharp
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
```

---

## 🌐 Como Rodar o Projeto Localmente

1. Certifique-se de ter o **Unity Hub** e a versão correta da Unity instalados.
2. Clone este repositório no seu computador usando o **GitHub Desktop**:
   ```bash
   https://github.com/usuario/nome-do-repositorio.git
   ```
3. No Unity Hub, clique em **Open** e selecione a pasta onde o projeto foi clonado.
4. Abra a cena principal localizada em `Assets/Scenes/MainScene.unity`.

## Feito por
[Rafins 𖹭.ᐟ](https://github.com/0001239178-ops)

[Raphael 𖦹.ᐟ](https://github.com/0001238702-tech)
