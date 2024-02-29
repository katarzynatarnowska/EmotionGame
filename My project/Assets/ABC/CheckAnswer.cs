using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject lettreOne, lettreTwo, lettreThree, lettreFour, lettreFive, lettreSix, lettreSeven,
                      lettreEight, lettreNine, BoxOne, BoxTwo, BoxThree, BoxFour, BoxFive, BoxSix;

    Vector3 lettreOneIni, lettreTwoIni, lettreThreeIni, lettreFourIni, lettreFiveIni, lettreSixIni, lettreSevenIni, lettreEightIni, lettreNineIni;                  

    string str="";
    public string word;

    public GameObject questionToHide, questionToShow;

    bool oneCorrect, twoCorrect, threeCorrect, fourCorrect, fiveCorrect, sixCorrect= false;
    

    Vector3 iniScaleLetterOne, iniScaleLetterTwo, iniScaleLetterThree, iniScaleLetterFour, iniScaleLetterFive, iniScaleLetterSix,
            iniScaleLetterSeven, iniScaleLetterEight, iniScaleLetterNine;


    // Start is called before the first frame update
    void Start()
    {

        
        lettreOneIni = lettreOne.transform.position;
        lettreTwoIni = lettreTwo.transform.position;
        lettreThreeIni = lettreThree.transform.position;
        lettreFourIni = lettreFour.transform.position;
        lettreFiveIni = lettreFive.transform.position;
        lettreSixIni = lettreSix.transform.position;
        lettreSevenIni = lettreSeven.transform.position;
        lettreEightIni = lettreEight.transform.position;
        lettreNineIni = lettreNine.transform.position;


        iniScaleLetterOne = lettreOne.transform.localScale;
        iniScaleLetterTwo = lettreTwo.transform.localScale;
        iniScaleLetterThree = lettreThree.transform.localScale;
        iniScaleLetterFour = lettreFour.transform.localScale;
        iniScaleLetterFive = lettreFive.transform.localScale;
        iniScaleLetterSix = lettreSix.transform.localScale;
        iniScaleLetterSeven = lettreSeven.transform.localScale;
        iniScaleLetterEight = lettreEight.transform.localScale;
        iniScaleLetterNine = lettreNine.transform.localScale;
        
    }

    public void DragLettreOne()
    {
    
            lettreOne.transform.position = Input.mousePosition;
    }
    
    
    public void DragLettreTwo()
    {
    
        lettreTwo.transform.position = Input.mousePosition;
        
    }
    
    public void DragLettreThree()
    {
    
        lettreThree.transform.position = Input.mousePosition;
        
    }

    public void DragLettreFour()
    {
       
        lettreFour.transform.position = Input.mousePosition;
        
    }
    
    public void DragLettreFive()
    {
        lettreFive.transform.position = Input.mousePosition;
    }
    
    
    public void DragLettreSix()
    {
       
        lettreSix.transform.position = Input.mousePosition;
    
    }
    
    public void DragLettreSeven()
    {
      
        lettreSeven.transform.position = Input.mousePosition;

    }
    
    public void DragLettreEight()
    {
     
        lettreEight.transform.position = Input.mousePosition;
    }
    
    public void DragLettreNine()
    {
    
        lettreNine.transform.position = Input.mousePosition;
    }


    public void DropLettreOne()
    {
        float Distance = Vector3.Distance(lettreOne.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreOne.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreOne.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreOne.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(lettreOne.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreOne.transform.position, BoxSix.transform.position);


        if (Distance<50 && oneCorrect==false)
        {
            lettreOne.transform.localScale = BoxOne.transform.localScale;
            lettreOne.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreOne.name;
            // source.clip = buttonDrop;
            // source.Play();
        }
        else if(Distance2 < 50 && twoCorrect==false)
        {
            lettreOne.transform.localScale = BoxTwo.transform.localScale;
            lettreOne.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreOne.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance3 < 50 && threeCorrect==false)
        {
            lettreOne.transform.localScale = BoxThree.transform.localScale;
            lettreOne.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreOne.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance4 < 50 && fourCorrect==false)
        {
            lettreOne.transform.localScale = BoxFour.transform.localScale;
            lettreOne.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = lettreOne.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance5 < 50 && fiveCorrect==false)
        {
            lettreOne.transform.localScale = BoxFive.transform.localScale;
            lettreOne.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreOne.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
         else if(Distance6 < 50 && sixCorrect==false)
        {
            lettreOne.transform.localScale = BoxSix.transform.localScale;
            lettreOne.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreOne.name;
            // source.clip = buttonDrop;
            // source.Play();

        }

        else
        {
            lettreOne.transform.position = lettreOneIni;
            // source.clip = reload;
            // source.Play();
        }
    }


     public void DropLettreTwo()
    {
        float Distance = Vector3.Distance(lettreTwo.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreTwo.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreTwo.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreTwo.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(lettreTwo.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreTwo.transform.position, BoxSix.transform.position);


        if (Distance<50 && oneCorrect==false)
        {
            lettreTwo.transform.localScale = BoxOne.transform.localScale;
            lettreTwo.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreTwo.name;
            // source.clip = buttonDrop;
            // source.Play();
        }
        else if(Distance2 < 50 && twoCorrect==false)
        {
            lettreTwo.transform.localScale = BoxTwo.transform.localScale;
            lettreTwo.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreTwo.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance3 < 50 && threeCorrect==false)
        {
            lettreTwo.transform.localScale = BoxThree.transform.localScale;
            lettreTwo.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreTwo.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance4 < 50 && fourCorrect==false)
        {
            lettreTwo.transform.localScale = BoxFour.transform.localScale;
            lettreTwo.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = lettreTwo.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance5 < 50 && fiveCorrect==false)
        {
            lettreTwo.transform.localScale = BoxFive.transform.localScale;
            lettreTwo.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreTwo.name;
            // source.clip = buttonDrop;
            // source.Play();

        }

         else if(Distance6 < 50 && sixCorrect==false)
        {
            lettreTwo.transform.localScale = BoxSix.transform.localScale;
            lettreTwo.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreTwo.name;
            // source.clip = buttonDrop;
            // source.Play();

        }

        else
        {
            lettreTwo.transform.position = lettreTwoIni;
            // source.clip = reload;
            // source.Play();
        }
    }




    public void DropLettreThree()
    {
        float Distance = Vector3.Distance(lettreThree.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreThree.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreThree.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreThree.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(lettreThree.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreThree.transform.position, BoxSix.transform.position);


        if (Distance<50 && oneCorrect==false)
        {
            lettreThree.transform.localScale = BoxOne.transform.localScale;
            lettreThree.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreThree.name;
            // source.clip = buttonDrop;
            // source.Play();
        }
        else if(Distance2 < 50 && twoCorrect==false)
        {
            lettreThree.transform.localScale = BoxTwo.transform.localScale;
            lettreThree.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreThree.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance3 < 50 && threeCorrect==false)
        {
            lettreThree.transform.localScale = BoxThree.transform.localScale;
            lettreThree.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreThree.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance4 < 50 && fourCorrect==false)
        {
            lettreThree.transform.localScale = BoxFour.transform.localScale;
            lettreThree.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = lettreThree.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance5 < 50 && fiveCorrect==false)
        {
            lettreThree.transform.localScale = BoxFive.transform.localScale;
            lettreThree.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreThree.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
         else if(Distance6 < 50 && sixCorrect==false)
        {
            lettreThree.transform.localScale = BoxSix.transform.localScale;
            lettreThree.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreThree.name;
            // source.clip = buttonDrop;
            // source.Play();

        }

        else
        {
            lettreThree.transform.position = lettreThreeIni;
            // source.clip = reload;
            // source.Play();
        }
    }



     public void DropLettreFour()
    {
        float Distance = Vector3.Distance(lettreFour.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreFour.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreFour.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreFour.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(lettreFour.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreFour.transform.position, BoxSix.transform.position);


        if (Distance<50 && oneCorrect==false)
        {
            lettreFour.transform.localScale = BoxOne.transform.localScale;
            lettreFour.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreFour.name;
            // source.clip = buttonDrop;
            // source.Play();
        }
        else if(Distance2 < 50 && twoCorrect==false)
        {
            lettreFour.transform.localScale = BoxTwo.transform.localScale;
            lettreFour.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreFour.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance3 < 50 && threeCorrect==false)
        {
            lettreFour.transform.localScale = BoxThree.transform.localScale;
            lettreFour.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreFour.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance4 < 50 && fourCorrect==false)
        {
            lettreFour.transform.localScale = BoxFour.transform.localScale;
            lettreFour.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = lettreFour.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance5 < 50 && fiveCorrect==false)
        {
            lettreFour.transform.localScale = BoxFive.transform.localScale;
            lettreFour.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreFour.name;
            // source.clip = buttonDrop;
            // source.Play();

        }

         else if(Distance6 < 50 && sixCorrect==false)
        {
            lettreFour.transform.localScale = BoxSix.transform.localScale;
            lettreFour.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreFour.name;
            // source.clip = buttonDrop;
            // source.Play();

        }

        else
        {
            lettreFour.transform.position = lettreFourIni;
            // source.clip = reload;
            // source.Play();
        }
    }



    public void DropLettreFive()
    {
        float Distance = Vector3.Distance(lettreFive.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreFive.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreFive.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreFive.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(lettreFive.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreFive.transform.position, BoxSix.transform.position);


        if (Distance<50 && oneCorrect==false)
        {
            lettreFive.transform.localScale = BoxOne.transform.localScale;
            lettreFive.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreFive.name;
            // source.clip = buttonDrop;
            // source.Play();
        }
        else if(Distance2 < 50 && twoCorrect==false)
        {
            lettreFive.transform.localScale = BoxTwo.transform.localScale;
            lettreFive.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreFive.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance3 < 50 && threeCorrect==false)
        {
            lettreFive.transform.localScale = BoxThree.transform.localScale;
            lettreFive.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreFive.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance4 < 50 && fourCorrect==false)
        {
            lettreFive.transform.localScale = BoxFour.transform.localScale;
            lettreFive.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = lettreFive.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance5 < 50 && fiveCorrect==false)
        {
            lettreFive.transform.localScale = BoxFive.transform.localScale;
            lettreFive.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreFive.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
         else if(Distance6 < 50 && sixCorrect==false)
        {
            lettreFive.transform.localScale = BoxSix.transform.localScale;
            lettreFive.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreFive.name;
            // source.clip = buttonDrop;
            // source.Play();

        }

        else
        {
            lettreFive.transform.position = lettreFiveIni;
            // source.clip = reload;
            // source.Play();
        }
    }


    public void DropLettreSix()
    {
        float Distance = Vector3.Distance(lettreSix.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreSix.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreSix.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreSix.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(lettreSix.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreSix.transform.position, BoxSix.transform.position);


        if (Distance<50 && oneCorrect==false)
        {
            lettreSix.transform.localScale = BoxOne.transform.localScale;
            lettreSix.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreSix.name;
            // source.clip = buttonDrop;
            // source.Play();
        }
        else if(Distance2 < 50 && twoCorrect==false)
        {
            lettreSix.transform.localScale = BoxTwo.transform.localScale;
            lettreSix.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreSix.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance3 < 50 && threeCorrect==false)
        {
            lettreSix.transform.localScale = BoxThree.transform.localScale;
            lettreSix.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreSix.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance4 < 50 && fourCorrect==false)
        {
            lettreSix.transform.localScale = BoxFour.transform.localScale;
            lettreSix.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = lettreSix.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance5 < 50 && fiveCorrect==false)
        {
            lettreSix.transform.localScale = BoxFive.transform.localScale;
            lettreSix.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreSix.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
         else if(Distance6 < 50 && sixCorrect==false)
        {
            lettreSix.transform.localScale = BoxSix.transform.localScale;
            lettreSix.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreSix.name;
            // source.clip = buttonDrop;
            // source.Play();

        }

        else
        {
            lettreSix.transform.position = lettreSixIni;
            // source.clip = reload;
            // source.Play();
        }
    }


    public void DropLettreSeven()
    {
        float Distance = Vector3.Distance(lettreSeven.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreSeven.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreSeven.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreSeven.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(lettreSeven.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreSeven.transform.position, BoxSix.transform.position);


        if (Distance<50 && oneCorrect==false)
        {
            lettreSeven.transform.localScale = BoxOne.transform.localScale;
            lettreSeven.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreSeven.name;
            // source.clip = buttonDrop;
            // source.Play();
        }
        else if(Distance2 < 50 && twoCorrect==false)
        {
            lettreSeven.transform.localScale = BoxTwo.transform.localScale;
            lettreSeven.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreSeven.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance3 < 50 && threeCorrect==false)
        {
            lettreSeven.transform.localScale = BoxThree.transform.localScale;
            lettreSeven.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreSeven.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance4 < 50 && fourCorrect==false)
        {
            lettreSeven.transform.localScale = BoxFour.transform.localScale;
            lettreSeven.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = lettreSeven.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance5 < 50 && fiveCorrect==false)
        {
            lettreSeven.transform.localScale = BoxFive.transform.localScale;
            lettreSeven.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreSeven.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
         else if(Distance6 < 50 && sixCorrect==false)
        {
            lettreSeven.transform.localScale = BoxSix.transform.localScale;
            lettreSeven.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreSeven.name;
            // source.clip = buttonDrop;
            // source.Play();

        }

        else
        {
            lettreSeven.transform.position = lettreSevenIni;
            // source.clip = reload;
            // source.Play();
        }
    }



    public void DropLettreEight()
    {
        float Distance = Vector3.Distance(lettreEight.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreEight.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreEight.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreEight.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(lettreEight.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreEight.transform.position, BoxSix.transform.position);


        if (Distance<50 && oneCorrect==false)
        {
            lettreEight.transform.localScale = BoxOne.transform.localScale;
            lettreEight.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreEight.name;
            // source.clip = buttonDrop;
            // source.Play();
        }
        else if(Distance2 < 50 && twoCorrect==false)
        {
            lettreEight.transform.localScale = BoxTwo.transform.localScale;
            lettreEight.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreEight.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance3 < 50 && threeCorrect==false)
        {
            lettreEight.transform.localScale = BoxThree.transform.localScale;
            lettreEight.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreEight.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance4 < 50 && fourCorrect==false)
        {
            lettreEight.transform.localScale = BoxFour.transform.localScale;
            lettreEight.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = lettreEight.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance5 < 50 && fiveCorrect==false)
        {
            lettreEight.transform.localScale = BoxFive.transform.localScale;
            lettreEight.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreEight.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
         else if(Distance6 < 50 && sixCorrect==false)
        {
            lettreEight.transform.localScale = BoxSix.transform.localScale;
            lettreEight.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreEight.name;
            // source.clip = buttonDrop;
            // source.Play();

        }

        else
        {
            lettreEight.transform.position = lettreEightIni;
            // source.clip = reload;
            // source.Play();
        }
    }


    public void DropLettreNine()
    {
        float Distance = Vector3.Distance(lettreNine.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(lettreNine.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(lettreNine.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(lettreNine.transform.position, BoxFour.transform.position);
        float Distance5 = Vector3.Distance(lettreNine.transform.position, BoxFive.transform.position);
        float Distance6 = Vector3.Distance(lettreNine.transform.position, BoxSix.transform.position);

        if (Distance<50 && oneCorrect==false)
        {
            lettreNine.transform.localScale = BoxOne.transform.localScale;
            lettreNine.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = lettreNine.name;
            // source.clip = buttonDrop;
            // source.Play();
        }
        else if(Distance2 < 50 && twoCorrect==false)
        {
            lettreNine.transform.localScale = BoxTwo.transform.localScale;
            lettreNine.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = lettreNine.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance3 < 50 && threeCorrect==false)
        {
            lettreNine.transform.localScale = BoxThree.transform.localScale;
            lettreNine.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = lettreNine.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
        else if(Distance4 < 50 && fourCorrect==false)
        {
            lettreNine.transform.localScale = BoxFour.transform.localScale;
            lettreNine.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = lettreNine.name;
            // source.clip = buttonDrop;
            // source.Play();

        }
       else if(Distance5 < 50 && fiveCorrect==false)
        {
            lettreNine.transform.localScale = BoxFive.transform.localScale;
            lettreNine.transform.position = BoxFive.transform.position;
            fiveCorrect = true;
            BoxFive.name = lettreNine.name;
            // source.clip = buttonDrop;
            // source.Play();

        }

        else if(Distance6 < 50 && sixCorrect==false)
        {
            lettreNine.transform.localScale = BoxSix.transform.localScale;
            lettreNine.transform.position = BoxSix.transform.position;
            sixCorrect = true;
            BoxSix.name = lettreNine.name;
            // source.clip = buttonDrop;
            // source.Play();

        }

        else
        {
            lettreNine.transform.position = lettreNineIni;
            // source.clip = reload;
            // source.Play();
        }
    }


    //Button

    public void Check()
    {
        str = BoxOne.name+BoxTwo.name+BoxThree.name+BoxFour.name+BoxFive.name+BoxSix.name;

        if(word==str)
        {
            
            StartCoroutine(LoadNextPanel());
        }
        
    }

    public void Reload()
    {
        str = "";

        

        oneCorrect = false;
        twoCorrect = false;
        threeCorrect = false;
        fourCorrect = false;
        fiveCorrect= false;
        sixCorrect= false;

        BoxOne.name="1";
        BoxTwo.name="2";
        BoxThree.name="3";
        BoxFour.name="4";
        BoxFive.name="5";
        BoxSix.name="6";


        lettreOne.transform.position = lettreOneIni;
        lettreTwo.transform.position = lettreTwoIni;
        lettreThree.transform.position = lettreThreeIni;
        lettreFour.transform.position = lettreFourIni;
        lettreFive.transform.position = lettreFiveIni;
        lettreSix.transform.position = lettreSixIni;
        lettreSeven.transform.position = lettreSevenIni;
        lettreEight.transform.position = lettreEightIni;
        lettreNine.transform.position = lettreNineIni;

        lettreOne.transform.localScale = iniScaleLetterOne;
        lettreTwo.transform.localScale = iniScaleLetterTwo;
        lettreThree.transform.localScale = iniScaleLetterThree;
        lettreFour.transform.localScale = iniScaleLetterFour;
        lettreFive.transform.localScale = iniScaleLetterFive;
        lettreSix.transform.localScale = iniScaleLetterSix;
        lettreSeven.transform.localScale = iniScaleLetterSeven;
        lettreEight.transform.localScale = iniScaleLetterEight;
        lettreNine.transform.localScale = iniScaleLetterNine;
    }

    IEnumerator LoadNextPanel()
    {
        yield return new WaitForSeconds(1f);
        questionToHide.SetActive(false);
        questionToShow.SetActive(true);
    }






}

