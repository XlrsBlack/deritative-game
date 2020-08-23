using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBiome : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] biomes = new string[] { "grasslands", "rainforest", "desert", "rocky", "swamp", "tundra" };
        System.Random random = new System.Random();
        int useBiome = random.Next(biomes.Length);
        string pickBiome = biomes[useBiome];
        print(pickBiome);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
