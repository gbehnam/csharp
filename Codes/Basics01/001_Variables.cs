using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cubePrefab;

    GameObject[] cubesArray = new GameObject[500];
    void Start()
    {
        string playerName = "Behnam";
        string equippedSkill = "Nothing really :(";
        string favoriteFruit = "Mango";

        string favoriteSport = "Basketball";

        print(favoriteSport);

        Debug.Log(playerName);
        Debug.Log(equippedSkill);
        Debug.Log(favoriteFruit);
        Debug.Log(favoriteSport.ToUpper());

        int hp = 100;
        float shieldLife = 76.8f;
        int gunDamage = 15;

        hp -= (int)(gunDamage * (shieldLife / 100.0));

        Debug.Log("HP: " + hp);
         
        double aDouble = 12312423423.123124134324;
        double aDoubleReaminder = aDouble % 113;
        print("The remiander of " + aDouble + " by " + 113 + " is: " + aDoubleReaminder);

        string[] playersArray = new string[4];

        playersArray [1] = "player2";
        playersArray [0] = "first player";

        Debug.Log(playersArray[0]);
        float spacer = .3f;

        for (int i = 0; i < cubesArray.Length; i++)
        {
            GameObject cube = Instantiate(cubePrefab);
            cubesArray[i] = cube;
            float newPositionX = (i ) / 100;
            float newPositionY = ((i ) % 100)/3;
            print("x: " + newPositionX + " y: " + newPositionY);
            cube.transform.position = new Vector3(newPositionX, newPositionY, cube.transform.position.z);
            cube.transform.localScale = new Vector3(1, 1, 1);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
