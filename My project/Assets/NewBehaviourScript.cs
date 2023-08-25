using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string heroName = "kakarot";

    float heroHeight = 5.7f;

    int heroAge = 48;

    string heroPower = "superstrength";

    string heroIntellegence = "76";


    string villainName = "freiza";

    float villainHeight = 4.11f;

    string villainPower = "fingerlaser";

    int villainAge = 50;

    string villainIntellegence = "150";

    int ageDifference = 48 - 50;
    
    // Start is called before the first frame update
    void Start()
    {
        print("my name is" + heroName);

        print("my height is" + heroHeight);

        print("my intellegence is" + heroIntellegence);

        print("my power is" + heroPower);

        print("my name is" + villainName);

        print("my height is" + villainHeight);

        print("my power is" + villainPower);

        print("my intellegence is" + villainIntellegence);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
