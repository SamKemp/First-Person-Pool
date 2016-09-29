#pragma strict

private var Score:float = 0.0f;

var textonscreen : UI.Text;

function Start ()
{

}

function Update ()
{
    if (Time.timeScale == 1)
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Score = Score + 1;
            textonscreen.text = "Score: " + Score;
        }
    }
}