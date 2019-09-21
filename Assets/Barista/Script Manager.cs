using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScriptManager : MonoBehaviour
{
    public InputField LargeCup;
    public InputField MediumCup;
    public InputField SmallCup;
    public InputField DoubleShotEspressoCup;
    public InputField EspressoShotCup;
    public Button Strong;
    public Button Regular;
    bool   IsStrong  = true;
    double Larg = 354;
    double Medium = 236;
    double Small = 118;
    double DoubleEspresso = 60;
    double Espresso = 30;
    double WaterDesired = 0;
    double WaterNeededML = 0;
    double WaterNeededOZ = 0;
    double CoffeeNeededGR = 0;
    double CoffeeNeededTBS = 0;


    public void FrenchPress()
    {
        if (IsStrong)
        {
            FrenchPressStrong(); 
        }
        if (!IsStrong)
        {
            FrenchPressRegular();
        }
    }
    public void FrenchPressRegular()
    {
        if (IsStrong)
        {

        }
        WaterDesired = ((double.Parse(LargeCup.text) * Larg))
                       + ((double.Parse(MediumCup.text) * Medium))
                       + ((double.Parse(SmallCup.text) * Small));
        WaterNeededML = WaterDesired * 1.31;    // I need 1.31 ml water for each ml Coffee.
        WaterNeededOZ = WaterNeededML * 0.0338; // Convert to ounce
        CoffeeNeededGR = WaterNeededML * 0.058; //for each ml we need 0.058 gr coffee.
        CoffeeNeededTBS = CoffeeNeededGR / 12; // Convert to Table Spoon.
    }

    public void FrenchPressStrong()
    {
        WaterDesired = ((double.Parse(LargeCup.text) * Larg))
                       + ((double.Parse(MediumCup.text) * Medium))
                       + ((double.Parse(SmallCup.text) * Small));
        WaterNeededML = WaterDesired * 1.34;   // I need 1.31 ml water for each ml Coffee.
        WaterNeededOZ = WaterNeededML * 0.0338; // Convert to ounce
        CoffeeNeededGR = WaterNeededML * 0.091; //for each ml we need 0.058 gr coffee.
        CoffeeNeededTBS = CoffeeNeededGR / 12; // Convert to Table Spoon.
    }

    public void PourOverRegular()
    {
        WaterDesired = ((double.Parse(LargeCup.text) * Larg))
                       + ((double.Parse(MediumCup.text) * Medium))
                       + ((double.Parse(SmallCup.text) * Small));
        WaterNeededML = WaterDesired * 1.31;    // I need 1.31 ml water for each ml Coffee.
        WaterNeededOZ = WaterNeededML * 0.0338; // Convert to ounce
        CoffeeNeededGR = WaterNeededML * 0.058; //for each ml we need 0.058 gr coffee.
        CoffeeNeededTBS = CoffeeNeededGR / 12; // Convert to Table Spoon.
    }

    public void PourOverStrong()
    {
        WaterDesired = ((double.Parse(LargeCup.text) * Larg))
                       + ((double.Parse(MediumCup.text) * Medium))
                       + ((double.Parse(SmallCup.text) * Small));
        WaterNeededML = WaterDesired * 1.31;    // I need 1.31 ml water for each ml Coffee.
        WaterNeededOZ = WaterNeededML * 0.0338; // Convert to ounce
        CoffeeNeededGR = WaterNeededML * 0.066; //for each ml we need 0.058 gr coffee.
        CoffeeNeededTBS = CoffeeNeededGR / 12; // Convert to Table Spoon.
    }

    public void ColdBrewRegular()
    {
        WaterDesired = ((double.Parse(LargeCup.text) * Larg))
                       + ((double.Parse(MediumCup.text) * Medium))
                       + ((double.Parse(SmallCup.text) * Small));
        WaterNeededML = WaterDesired * 0.125;    // I need 1.31 ml water for each ml Coffee.
        WaterNeededOZ = WaterNeededML * 0.0338; // Convert to ounce
        CoffeeNeededGR = WaterNeededML * 0.125; //for each ml we need 0.058 gr coffee.
        CoffeeNeededTBS = CoffeeNeededGR / 12; // Convert to Table Spoon.
    }

    public void ColdBrewStrong()
    {
        WaterDesired = ((double.Parse(LargeCup.text) * Larg))
                       + ((double.Parse(MediumCup.text) * Medium))
                       + ((double.Parse(SmallCup.text) * Small));
        WaterNeededML = WaterDesired * 0.200;    // I need 1.31 ml water for each ml Coffee.
        WaterNeededOZ = WaterNeededML * 0.0338; // Convert to ounce
        CoffeeNeededGR = WaterNeededML * 0.199; //for each ml we need 0.058 gr coffee.
        CoffeeNeededTBS = CoffeeNeededGR / 12; // Convert to Table Spoon.
    }

    public void AeroPressRegular() //Aeropress is the same az FrenchPress
    {
        WaterDesired = ((double.Parse(LargeCup.text) * Larg))
                       + ((double.Parse(MediumCup.text) * Medium))
                       + ((double.Parse(SmallCup.text) * Small));
        WaterNeededML = WaterDesired * 1.31;    // I need 1.31 ml water for each ml Coffee.
        WaterNeededOZ = WaterNeededML * 0.0338; // Convert to ounce
        CoffeeNeededGR = WaterNeededML * 0.058; //for each ml we need 0.058 gr coffee.
        CoffeeNeededTBS = CoffeeNeededGR / 12; // Convert to Table Spoon.
    }

    public void AeroPressStrong()  //Aeropress is the same az FrenchPress
    {
        WaterDesired = ((double.Parse(LargeCup.text) * Larg))
                       + ((double.Parse(MediumCup.text) * Medium))
                       + ((double.Parse(SmallCup.text) * Small));
        WaterNeededML = WaterDesired * 1.34;   // I need 1.31 ml water for each ml Coffee.
        WaterNeededOZ = WaterNeededML * 0.0338; // Convert to ounce
        CoffeeNeededGR = WaterNeededML * 0.091; //for each ml we need 0.058 gr coffee.
        CoffeeNeededTBS = CoffeeNeededGR / 12; // Convert to Table Spoon.
    }

    public void EspressoRegAndStrong()  
    {
        WaterDesired = (double.Parse(EspressoShotCup.text)*Espresso) + (double.Parse(DoubleShotEspressoCup.text) * DoubleEspresso);
        WaterNeededML = WaterDesired;   // I need 1.31 ml water for each ml Coffee.
        WaterNeededOZ = WaterNeededML * 0.0338; // Convert to ounce
        CoffeeNeededGR = double.Parse(EspressoShotCup.text) * 8;
        CoffeeNeededTBS = CoffeeNeededGR / 12; // Convert to Table Spoon.   
    }

    public void TurkishCoffee()
    {
        WaterDesired = (double.Parse(EspressoShotCup.text) * Espresso) + (double.Parse(DoubleShotEspressoCup.text) * DoubleEspresso);
        WaterNeededML = WaterDesired * 1.5 ;   // I need 1.31 ml water for each ml Coffee.
        WaterNeededOZ = WaterNeededML * 0.0338; // Convert to ounce
        CoffeeNeededGR = ((double.Parse(EspressoShotCup.text)) + (double.Parse(DoubleShotEspressoCup.text))) * 12 ;
        CoffeeNeededTBS = CoffeeNeededGR / 12; // Convert to Table Spoon.   
    }
}
