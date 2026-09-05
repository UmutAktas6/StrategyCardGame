using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NationHexState 
{
    private bool visible;
    private bool explored;
    private bool mapped;

    Hex _hex;
    Nation _nation;

    //Ýleride yukarýdaki 3 lünün hepsi birer class olabilir veya baþka bir liste, dictionary, sözlük yada bir parent
    //classýn childý olabilir mesela ExploredInfo ile hangi Nation Explore etti bilgisi gerekebilir þimdilik bunlarý
    //classa veya baþka bir veri türüne dönüþtürmek yerine private bool ve property ile hallediyorum dýþa da kapý 
    //açýyorum ama ileride duruma göre çok deðiþebilir bool kalýr ekstra dýþa açýlan kapýlarla bu ExploredInfo vs de
    //Dýþa verilebilir komple sistem deðiþip class sistemine de geçilebilir.

    public Hex hex;
    public NationHexState(Hex hex, Nation nation)
    {
        _hex = hex;
        _nation = nation;
    }

    public bool Explore()
    {
        if (!explored)
        {
            //Deneme aþaðýyý sil.

            Debug.Log("Nation explored hex at " + _hex.coordinate);

            explored = true;
            return true;
        }
        return false;
    }
}
