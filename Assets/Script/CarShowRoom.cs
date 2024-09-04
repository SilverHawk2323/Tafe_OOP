using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarShowRoom : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // new ClassName() <---- Turns an object out of the class
        FM1Car AnthonyCar = new FM1Car("Anthony", "Red", 300f);
        FM1Car DomCar = new FM1Car("Dom", "Green", 88f);
        Tank AndrewCar = new Tank("Andrew", "Pink", 77f);

        /*AnthonyCar.SetUpCar("Anthony", "Red", 300f);
        DomCar.SetUpCar("Dom", "Green", 88f);*/

        AnthonyCar.PrintColour();
        DomCar.PrintColour();
        AndrewCar.PrintColour();
        AnthonyCar.HoverMode();

        Race(AnthonyCar, AndrewCar);
    }

    void Race (Car car1, Car car2)
    {
        if(car1.speed > car2.speed)
        {
            Debug.Log("HERE IS YOUR WINNER: " + car1.VictorySpeech());
        }
        else
        {
            Debug.Log("HERE IS YOUR WINNER: " + car2.VictorySpeech());
        }
    }

}
