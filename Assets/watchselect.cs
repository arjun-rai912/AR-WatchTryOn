using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class watchselect : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject watchModel1;
    public GameObject watchModel2;
    public GameObject watchModel3;

    public GameObject w1Window;
    public GameObject w2Window;
    public GameObject w3Window;

    Animation w1WindowAnimation;
    Animation w2WindowAnimation;
    Animation w3WindowAnimation;

    void Start()
    {
        w1WindowAnimation = w1Window.GetComponent<Animation>();
        w2WindowAnimation = w2Window.GetComponent<Animation>();
        w3WindowAnimation = w3Window.GetComponent<Animation>();
        
    }
    public void WatchOneButtonClicked(){
         
           w1WindowAnimation["w1animation"].speed=1;
           w1WindowAnimation.Play();
    }
    public void WatchTwoButtonClicked(){
        
              w2WindowAnimation["w2animation"].speed=1;
           w2WindowAnimation.Play();
    }
    public void WatchThreeButtonClicked(){
         
              w3WindowAnimation["w3animation"].speed=1;
           w3WindowAnimation.Play();
    }

    public void CloseButtonClicked(){
      string buttonName=EventSystem.current.currentSelectedGameObject.name;
      if(buttonName == "w1close"){
          w1WindowAnimation["w1animation"].speed=-1;
           w1WindowAnimation["w1animation"].time=w1WindowAnimation["w1animation"].length;
           w1WindowAnimation.Play();
      }else if(buttonName == "w2close"){
            w2WindowAnimation["w2animation"].speed=-1;
             w2WindowAnimation["w2animation"].time=w2WindowAnimation["w2animation"].length;
             w2WindowAnimation.Play();
      }
      
      else if(buttonName == "w3close"){
              w3WindowAnimation["w3animation"].speed=-1;
               w3WindowAnimation["w3animation"].time=w3WindowAnimation["w3animation"].length;
           w3WindowAnimation.Play();
      }
    }
   
}
