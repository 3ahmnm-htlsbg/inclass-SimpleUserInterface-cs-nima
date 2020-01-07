using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class SimpleUserInterface : MonoBehaviour
{

    public InputField textInput;
    public Button text_Btn;
    public Button count_Btn;
    public Text textTransfer;
    public Text textNumber;

    int counter;


   public void transferText()
    {
        textTransfer.text = textInput.text;
        
       
    }

    public void count()
    {
       
        counter += 1;
        textNumber.text = counter.ToString();

    }

   


 

}
