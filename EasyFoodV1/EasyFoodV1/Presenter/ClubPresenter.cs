using System;
using System.Collections.Generic;
using System.Text;
using DataModel;
using Xamarin.Forms;

namespace EasyFoodV1.Presenter
{
    class ClubPresenter
    {
        public List<Club> FillClubs()
        {
            List<Club> AllClubs = new List<Club>();
            Club Ahly = new Club();
            Ahly.ClubName = "El-Ahly FC";
            Ahly.ClubAddress = "Giza - Gazira";
            Ahly.ClubImg = "ahlylogo.png";
            AllClubs.Add(Ahly);

            Club Zamalek = new Club();
            Zamalek.ClubName = "Zamalek SC";
            Zamalek.ClubAddress = "Giza - Mohandseen";
            Zamalek.ClubImg = "zamaleklogo.png";
            AllClubs.Add(Zamalek);

            Club Masry = new Club();
            Masry.ClubName = "Al-Masry";
            Masry.ClubAddress = "Port-Saied";
            Masry.ClubImg = "masry.png";
            AllClubs.Add(Masry);

            Club Moka = new Club();
            Moka.ClubName = "Al-Mokawlon";
            Moka.ClubAddress = "Cairo";
            Moka.ClubImg = "mokawlon.png";
            AllClubs.Add(Moka);

            Club Wadi = new Club();
            Wadi.ClubName = "Wadi Degla";
            Wadi.ClubAddress = "6 Oct";
            Wadi.ClubImg = "wadideglalogo.png";
            AllClubs.Add(Wadi);

            Club Pyrmds = new Club();
            Pyrmds.ClubName = "Pyramids";
            Pyrmds.ClubAddress = "Asiut";
            Pyrmds.ClubImg = "pyramidslogo.png";
            AllClubs.Add(Pyrmds);

            Club Shorta = new Club();
            Shorta.ClubName = "Etehad-Elshorta";
            Shorta.ClubAddress = "Cairo - Nassr city";
            Shorta.ClubImg = "policeunion.png";
            AllClubs.Add(Shorta);

            Club Liver = new Club();
            Liver.ClubName = "LiverPool";
            Liver.ClubAddress = "Liverpool - England";
            Liver.ClubImg = "liverpool.png";
            AllClubs.Add(Liver);

            Club Parsa = new Club();
            Parsa.ClubName = "FCB";
            Parsa.ClubAddress = "Catalonya - Spain";
            Parsa.ClubImg = "fcb.png";
            AllClubs.Add(Parsa);

            Club Rlm = new Club();
            Rlm.ClubName = "Real Madrid";
            Rlm.ClubAddress = "Madrid - Spain";
            Rlm.ClubImg = "realmadrid.png";
            AllClubs.Add(Rlm);

            Club Paris = new Club();
            Paris.ClubName = "Paris Saint german";
            Paris.ClubAddress = "Paris - France";
            Paris.ClubImg = "parissant.png";
            AllClubs.Add(Paris);

            return AllClubs;
        }


    }
}
