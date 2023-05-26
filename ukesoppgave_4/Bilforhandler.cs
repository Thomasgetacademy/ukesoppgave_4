namespace ukesoppgave_4;

public class Bilforhandler
{
    private string Navn;
    private string Adresse;
    public List<Bil> Biler = new List<Bil>();

    public Bilforhandler(string navn, string adresse)
    {
        Navn = navn;
        Adresse = adresse;
    }

    public void AddBil(Bil car)
    {
        Biler.Add(car);
    }

    public void RemoveBil(string regNr)
    {
        foreach (var bil in Biler)
        {
            if (bil.RegNr == regNr)
            {
                Biler.Remove(bil);
                break;
            }
        }
    }
    public List<Bil> carListXYearsOld(int år)
    {
        var list = new List<Bil>();
        foreach (var car in Biler)
        {
            if (car.Årgang < år)
            {
                list.Add(car);
            }
        }
        return list;
    }
    public List<Bil> carListXKilometersDriven(int kilometers)
    {
        var list = new List<Bil>();
        foreach (var car in Biler)
        {
            if (car.KilometerGått > kilometers)
            {
                list.Add(car);
            }
        }
        return list;
    }

    public List<Bil> GetAllCars()
    {
        return Biler;
    }



}
