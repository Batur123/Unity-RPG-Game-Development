using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;	
using UnityEngine.SceneManagement;

public class AnaMenu : MonoBehaviour {

    ClassSystem degerler = new ClassSystem();

    public Text strength, intelligence, dexterity, armor, luck;
    public int str1=5, dex1=5, int1=5, armor1=5, luck1=5;
    public Button Warrior1, Rogue1, Wizard1;
    public Toggle Normal, Hard, Hell;
    public Button Basla;
    public Toggle WizSec, RogSec, WarSec;
    public Text ClassSecimYazi;
    public string ClassSecimYazi1;
 
    void Start () {

        str1 = degerler.strength;
        dex1 = degerler.dexterity;
        int1 = degerler.intelligence;
        armor1 = degerler.armor;
        luck1 = degerler.luck; 

        strength.text = str1.ToString() + "(+0)";
        intelligence.text = int1.ToString() + "(+0)";
        dexterity.text = dex1.ToString() + "(+0)";
        armor.text = armor1.ToString() + "(+0)";
        luck.text = luck1.ToString() + "(+0)";

    }
	
    public void WarriorSec()
    {
        str1 = 7; 
        dex1 = 3; 
        int1 = 3; 
        armor1 = 7; 
        luck1 = 5;

        WarSec.isOn = true;
        WizSec.isOn = false;
        RogSec.isOn = false;

        strength.text = str1.ToString() + "(+2)";
        intelligence.text = int1.ToString() + "(-2)";
        dexterity.text = dex1.ToString() + "(-2)";
        armor.text = armor1.ToString() + "(+2)";
        luck.text = luck1.ToString() + "(+0)";

        ClassSecimYazi1 = "Warrior";
        ClassSecimYazi.text = ClassSecimYazi1;

        



    }

    public void WizardSec()
    {
        str1 = 3;
        dex1 = 3;
        int1 = 7;
        armor1 = 6;
        luck1 = 5;

        WizSec.isOn = true;
        WarSec.isOn = false;
        RogSec.isOn = false;

        strength.text = str1.ToString() + "(-2)";
        intelligence.text = int1.ToString() + "(+2)";
        dexterity.text = dex1.ToString() + "(-2)";
        armor.text = armor1.ToString() + "(+1)";
        luck.text = luck1.ToString() + "(+0)";

        ClassSecimYazi1 = "Wizard";
        ClassSecimYazi.text = ClassSecimYazi1;
    }



    public void RogueSec()
    {

        str1 = 3;
        dex1 = 7;
        int1 = 4;
        armor1 = 6;
        luck1 = 5;

        RogSec.isOn = true;
        WizSec.isOn = false;
        WarSec.isOn = false;

        strength.text = str1.ToString() + "(-2)";
        intelligence.text = int1.ToString() + "(-1)";
        dexterity.text = dex1.ToString() + "(+2)";
        armor.text = armor1.ToString() + "(+1)";
        luck.text = luck1.ToString() + "(+0)";

        ClassSecimYazi1 = "Rogue";
        ClassSecimYazi.text = ClassSecimYazi1;
    }



	// Update is called once per frame
	void Update () {

 
        Warrior1.onClick.AddListener(() => { WarriorSec(); });
        Wizard1.onClick.AddListener(() => { WizardSec(); });
        Rogue1.onClick.AddListener(() => { RogueSec(); });

        Basla.onClick.AddListener(() => { OyunuBaslat(); });

    }

    void OyunuBaslat()
    {
        SceneManager.LoadScene("Oyun", LoadSceneMode.Additive);


    }
}
