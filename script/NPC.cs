using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //variaveis
    public int saude = 5;
    public int level = 1;
    public float speed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        saude = saude + level;
        print("Vidas: " + saude);

        


    }

    // Update is called once per frame
    void Update()
    {
       //criando variavel de posição
       //vector3 jogos 3d/vector2 jogos 2d

        Vector3 novaposicao = transform.position;

        //atribuir velocidade
        novaposicao.x = novaposicao.x + speed * Time.deltaTime;

        //nova velocidade do objeto

        transform.position = novaposicao;




    }
}
