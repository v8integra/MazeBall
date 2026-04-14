using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameManager gm;
    

  private void OnCollisionEnter(Collision collision)
  {
    if(collision.gameObject.tag == "winPlane")
        {
            gm.GameWin();
        }
  }
}
