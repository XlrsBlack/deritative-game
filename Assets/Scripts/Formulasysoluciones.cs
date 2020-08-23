using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Formulasysoluciones : MonoBehaviour
{    
    public int CantidadDeEjercicios = 42 ;
    public int num1, num2;
    public TEXDraw TEXdraw , TEXDraw1, TEXDraw2, TEXDraw3, TEXDraw4;
    private string pickformula1,pickformula2,pickformula3,pickformula4, sol;
    //Creo otros metodos para mi switch para ahorrar lineas evitando redundancia y tambien conseguir un String en forma aleatoria  
    void randomsol()
    {
        string[] formulas = new string[] { "(c)'= 0", "(x)'= 1", "(c.x)' = c.x ", "(c.u)'= c.(u)'", "(x^n)=n.x^{(n-1)}" };
        System.Random random = new System.Random();
        int ubicacionvector = random.Next(formulas.Length);
        pickformula1 = formulas[ubicacionvector];
        ubicacionvector = random.Next(formulas.Length);
        pickformula2 = formulas[ubicacionvector];
        ubicacionvector = random.Next(formulas.Length);
        pickformula3 = formulas[ubicacionvector];
        ubicacionvector = random.Next(formulas.Length);
        pickformula4 = formulas[ubicacionvector];
    }
    void fsolucion()
    {
        switch (num1)
        {
            case 1:
                TEXdraw.m_Text = "Y = 10+10";
                sol = "(c)' = 0";
                modulodefsolucion();
                break;
            case 2:
                TEXdraw.m_Text = "Y = x";
                sol = "(x)' = 1";
                modulodefsolucion();
                break;
            case 3:
                TEXdraw.m_Text = "Y = 2.x";
                sol = "(c.x)' = c.x";
                modulodefsolucion();
                break;
            case 4:
                TEXdraw.m_Text = "Y = 2(2x+3)";
                sol = "(c.u)' = c.(u)'";
                modulodefsolucion();
                break;
            case 5:
                TEXdraw.m_Text = "Y = x^6";
                sol = "(x^n) = n.x^{(n-1)}";
                modulodefsolucion();
                break;
            case 6:
                TEXdraw.m_Text = "Y = (8x-3x)^{4}";
                sol = "(u^n) = u'.u^{(n-1)}.n";
                modulodefsolucion();
                break;
            case 7:
                TEXdraw.m_Text = "Y = e^{x}";
                sol = "(e^x) = e^x.x'";
                modulodefsolucion();
                break;
            case 8:
                TEXdraw.m_Text = "Y = e^{5x+2}";
                sol = "(e^u) = u'.e^u";
                modulodefsolucion(); 
                break;
            case 9:
                TEXdraw.m_Text = "Y = 4^{9x-2}";
                sol = "(c^u) = c^u.Ln C.U";
                modulodefsolucion();
                break;
            case 10:
                TEXdraw.m_Text = "Y = 6x+7^{9x2y}";
                sol = "(u^w) = w.u^{(w-1)}.";
                modulodefsolucion();
                break;
            case 11:
                TEXdraw.m_Text = "Y = (2x+9)+(1h-9+2)-(5x+3) ";
                sol = @"(u \pm v \pm w)' = u'\pm v' \pm w'";
                modulodefsolucion();
                break;
            case 12:
                TEXdraw.m_Text = "Y = (6x+3).(11a+3)";
                sol = "(u.v)' = u'.v + v'.u";
                modulodefsolucion();
                break;
            case 13:
                TEXdraw.m_Text = "Y = \frac{12x+4}{5-3x}";
                sol = "(\frac{u}{v})' = \frac{u'.v - v'.u}{v^2}";
                modulodefsolucion();
                break;
            case 14:
                TEXdraw.m_Text = "Y = Ln x";
                sol = "(Ln x)' = \frac{1}{x}.x'";
                modulodefsolucion();
                break;
            case 15:
                TEXdraw.m_Text = "Y = Ln (12p-50)";
                sol = "(Ln u)'= \frac{u'}{u}";
                modulodefsolucion();
                break;
            case 16:
                TEXdraw.m_Text = "Y = Log_{2}x";
                sol = "(log_{a}x)' = \frac{1}{x.Ln a}";
                modulodefsolucion();
                break;
            case 17:
                TEXdraw.m_Text = "Y = Log_{2}(25k-6)";
                sol = "(Log_{a}U)' = \frac{(u)'}{u.Ln a}";
                modulodefsolucion();
                break;
            case 18:
                TEXdraw.m_Text = "Y = Sen X";
                sol = "(Sen x)' = Cos x";
                modulodefsolucion();
                break;
            case 19:
                TEXdraw.m_Text = "Y = Sen (2a-70)";
                sol = "(Sen u)' = u'.Cos u";
                modulodefsolucion();
                break;
            case 20:
                TEXdraw.m_Text = "Y = Cos X";
                sol = "(Cos x)' = - Sen x";
                modulodefsolucion();
                break;
            case 21:
                TEXdraw.m_Text = "Y = Cos (5h+5f)";
                sol = "(Cos u)' = -u.Sen u";
                modulodefsolucion();
                break;
            case 22:
                TEXdraw.m_Text = "Y = Tan 2";
                sol = "(Tan x)' = Sec^2 x";
                modulodefsolucion();
                break;
            case 23:
                TEXdraw.m_Text = "Y = Tan (40h+30v)";
                sol = "(Tan u)' = (u)'.Sec^2 u";
                modulodefsolucion();
                break;
            case 24:
                TEXdraw.m_Text = "Y = Sec 5";
                sol = "(Sec x)' = Sec x. Tg x";
                modulodefsolucion();
                break;
            case 25:
                TEXdraw.m_Text = "Y = Sec (2f+6h)";
                sol = "(Sec u)' = (u)'.Sec u .Tg u";
                modulodefsolucion();
                break;
            case 26:
                TEXdraw.m_Text = "Y = Csc x";
                sol = "(Csc x)' = -csc x.ctg x";
                modulodefsolucion();
                break;
            case 27:
                TEXdraw.m_Text = "Y = Csc (-5+10x)";
                sol = "(Csc u)'= (-u)'.Csc u.Ctg u";
                modulodefsolucion();
                break;
            case 28:
                TEXdraw.m_Text = "Y = Ctg 24";
                sol = "(Ctg x)'= - CSC^2 x";
                modulodefsolucion();
                break;
            case 29:
                TEXdraw.m_Text = "Y = Ctg (8x-5)";
                sol = "(Ctg u)'= (-u)'.Csc^2 u";
                modulodefsolucion();
                break;
            case 30:
                TEXdraw.m_Text = "Y = Arco Sen x";
                sol = @"(Arco Sen x)'= \frac{1}{\sqrt{1-x^2}}";
                modulodefsolucion();
                break;
            case 31:
                TEXdraw.m_Text = "Y = Arco Sen (12x-3)";
                sol = @"(Arco Sen u)'= \frac{(u)'}{\sqrt{1-u^2}}";
                modulodefsolucion();
                break;
            case 32:
                TEXdraw.m_Text = "Y = Arco Tan x";
                sol = "(Arco Tan x)' = \frac{1}{1+x^2}";
                modulodefsolucion();
                break;
            case 33:
                TEXdraw.m_Text = "Y = Arco Tan (15x+15)";
                sol = "(Arco Tan U)' = \frac{(u)'}{1+u^2}";
                modulodefsolucion();
                break;
            case 34:
                TEXdraw.m_Text = "Y = Arco Cos x";
                sol = @"(Arco Cos x)'=-\frac{1}{\sqrt{1-x^2}}";
                modulodefsolucion();
                break;
            case 35:
                TEXdraw.m_Text = "Y = Arco Cos (33x+4h)";
                sol = @"(Arco Cos u)' = -\frac{(u)'}{\sqrt{1-u^2}}";
                modulodefsolucion();
                break;
            case 36:
                TEXdraw.m_Text = "Y = Arco Sec x";
                sol = @"(Arco Sec x)' = \frac{1}{\sqrt{x^2-1}}";
                modulodefsolucion();
                break;
            case 37:
                TEXdraw.m_Text = "Y = Arco Sec (2h+5h)";
                sol = @"(Arco Sec u)' = \frac{(u)'}{\sqrt{u^2-1}}";
                modulodefsolucion();
                break;
            case 38:
                TEXdraw.m_Text = "Y = Arco Csc x";
                sol = @"(Arco Csc x)' = -\frac{1}{\sqrt{x^2-1}}";
                modulodefsolucion();
                break;
            case 39:
                TEXdraw.m_Text = "Y = Arco Csc (22x+34)";
                sol = @"(Arco Csc u)' = \frac{(u)'}{\sqrt{u^2-1}}";
                modulodefsolucion();
                break;
            case 40:
                TEXdraw.m_Text = "Y = Arco Ctg x";
                sol = "(Arco Ctg x)' = -\frac{1}{1-x^2}";
                modulodefsolucion();
                break;
            case 41:
                TEXdraw.m_Text = "Y = Arco Ctg (31x+4)";
                sol = "(Arco Ctg u)' = -\frac{(u)'}{1-u^2}";
                modulodefsolucion();
                break;
            case 42:
                TEXdraw.m_Text = @"Y = \sqrt[2]{(5x-15)}";
                sol = @"(\sqrt[n]{u})' = \frac{n.(u)'}{n.\sqrt[n]{u^{n-1}}}";
                modulodefsolucion();
                break;
        }
    }
    void modulodefsolucion()
    {
        switch (num2)
        {
            case 1:
                TEXDraw1.m_Text = sol;
                TEXDraw2.m_Text = pickformula2;
                TEXDraw3.m_Text = pickformula3;
                TEXDraw4.m_Text = pickformula4;
                break;
            case 2:
                TEXDraw1.m_Text = pickformula1;
                TEXDraw2.m_Text = sol;
                TEXDraw3.m_Text = pickformula3;
                TEXDraw4.m_Text = pickformula4;
                break;
            case 3:
                TEXDraw1.m_Text = pickformula1;
                TEXDraw2.m_Text = pickformula2;
                TEXDraw3.m_Text = sol;
                TEXDraw4.m_Text = pickformula4;
                break;
            case 4:
                TEXDraw1.m_Text = pickformula1;
                TEXDraw2.m_Text = pickformula2;
                TEXDraw3.m_Text = pickformula3;
                TEXDraw4.m_Text = sol;
                break;
        }
    }
// Start is called before the first frame update
public void Start()
    {
        num1 = Random.Range(1, CantidadDeEjercicios);
        num2 = Random.Range(1, 4);
        randomsol();
    }
    // Update is called once per frame
     void Update()
    {
        fsolucion();
    }
}