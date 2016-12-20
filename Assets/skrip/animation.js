#pragma strict
var idle="";
var jalan="";
var serangan="";
var jurus1="";
var jurus2="";
var jurus3="";
var jurus4="";
var stik:GameObject;
private var move:float;
/*var audio1 : AudioClip; 
var audio2 : AudioClip;
var audio3 : AudioClip;*/

function Update () {

	move = stik.transform.position.x;
	//GetComponent.<Animation>().Play(idle);
	if (Input.GetAxis("Horizontal"))
	{
		GetComponent.<Animation>().Play(jalan);
		GetComponent.<Animation>().Stop(idle);
	}
	else if (Input.GetAxis("Vertical"))
	{
		GetComponent.<Animation>().Play(jalan);
		GetComponent.<Animation>().Stop(idle);
	}
	//edit abis makan
	/*if (Input.GetMouseButtonUp(0))
	{
		GetComponent.<Animation>().Play(idle);
		GetComponent.<Animation>().Stop(jalan);
	}*/
	
	/*if (Input.GetKeyUp(KeyCode.J))
	{
		GetComponent.<Animation>().Play(mukul);
		GetComponent.<AudioSource>().clip = audio1;
		GetComponent.<AudioSource>().Play();
	}*/
	else
	{
		GetComponent.<Animation>().PlayQueued(idle);
	}
}

public function Attack()
{
	GetComponent.<Animation>().Play(serangan);
	GetComponent.<Animation>().Stop(idle);
}

public function Skill1()
{
	GetComponent.<Animation>().Play(jurus1);
	GetComponent.<Animation>().Stop(idle);
}

public function Skill2()
{
	GetComponent.<Animation>().Play(jurus2);
	GetComponent.<Animation>().Stop(idle);
}

public function Skill3()
{
	GetComponent.<Animation>().Play(jurus3);
	GetComponent.<Animation>().Stop(idle);
}

public function Skill4()
{
	GetComponent.<Animation>().Play(jurus4);
	GetComponent.<Animation>().Stop(idle);
}