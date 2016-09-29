#pragma strict

private var Time:float = 0.0f;

var textonscreen : UI.Text;

var myVar;

function Start ()
{
    InvokeRepeating("alertFunc", 0, 1.0);
}

function Update ()
{
    
}


function alertFunc()
{
    Time = Time + 1;
    textonscreen.text = " " + Time;
}