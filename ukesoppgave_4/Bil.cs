using System.Runtime.CompilerServices;

namespace ukesoppgave_4;

public class Bil
{
    public string Merke { get; private set; }
    public string RegNr { get; private set; }
    public int Årgang { get; private set; }
    public int KilometerGått { get; private set; }

    public Bil(string merke, string regNr, int årgang, int kilometerGått)
    {
        Merke = merke;
        RegNr = regNr;
        Årgang = årgang;
        KilometerGått = kilometerGått;
    }

    //public string GetRegNr()
    //{
    //    return RegNr;
    //}

    //public int GetÅrgang()
    //{
    //    return Årgang;
    //}

    //public int GetKilometersDriven()
    //{
    //    return KilometerGått;
    //}
}