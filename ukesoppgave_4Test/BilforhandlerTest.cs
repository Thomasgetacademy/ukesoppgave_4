using ukesoppgave_4;

namespace ukesoppgave_4Test
{
    public class BilforhandlerTest
    {
        [Test]
        public void TestAddCar()
        {
            Bilforhandler bilforhandler = new Bilforhandler("Sjøen Bilforhandler", "Kvesegrålia 3");
            var newCar = new Bil("Mercedes", "293FIL", 2009, 134000);
            bilforhandler.AddBil(newCar);
            Assert.AreEqual(1, bilforhandler.Biler.Count);
            Assert.AreEqual("293FIL", bilforhandler.Biler[0].RegNr);
        }
        [Test]
        public void TestRemoveCar()
        {
            Bilforhandler bilforhandler = new Bilforhandler("Sjøen Bilforhandler", "Kvesegrålia 3");
            var newCar = new Bil("Mercedes", "293FIL", 2009, 134000);
            bilforhandler.AddBil(newCar);
            bilforhandler.AddBil(newCar);
            bilforhandler.RemoveBil(newCar.RegNr);

            Assert.AreEqual(1, bilforhandler.Biler.Count);
        }
        [Test]
        public void TestCarKilometersDriven()
        {
            Bilforhandler bilforhandler = new Bilforhandler("Sjøen Bilforhandler", "Kvesegrålia 3");
            var newCar = new Bil("Mercedes", "213FIL", 2015, 134000);
            var newCar2 = new Bil("Mercedes", "283FIL", 2011, 136000);
            bilforhandler.AddBil(newCar);
            bilforhandler.AddBil(newCar2);
            var listWithCars = bilforhandler.carListXKilometersDriven(135000);

            Assert.AreEqual(1, listWithCars.Count);
        }
        [Test]
        public void carListXYearsOld()
        {
            Bilforhandler bilforhandler = new Bilforhandler("Sjøen Bilforhandler", "Kvesegrålia 3");
            var newCar = new Bil("Mercedes", "213FIL", 2015, 134000);
            var newCar2 = new Bil("Mercedes", "283FIL", 2011, 136000);
            bilforhandler.AddBil(newCar);
            bilforhandler.AddBil(newCar2);

            var listWithCars = bilforhandler.carListXYearsOld(2013);

            Assert.AreEqual(1, listWithCars.Count);
        }
        [Test]
        public void GetAllCars()
        {
            Bilforhandler bilforhandler = new Bilforhandler("Sjøen Bilforhandler", "Kvesegrålia 3");
            var newCar = new Bil("Mercedes", "213FIL", 2015, 134000);
            var newCar2 = new Bil("Mercedes", "283FIL", 2011, 136000);
            bilforhandler.AddBil(newCar);
            bilforhandler.AddBil(newCar2);

            var listWithCars = bilforhandler.GetAllCars();

            Assert.AreEqual(2, listWithCars.Count);
        }

    }
}