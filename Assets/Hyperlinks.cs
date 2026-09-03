using UnityEngine;

public class Hyperlinks : MonoBehaviour
{
    public void OpenLink(){
        Application.OpenURL("https://www.youtube.com/watch?v=tCKdyJ9Qo_o");
    }

    public void OpenURL(string link){
        Application.OpenURL(link);
    }


}
