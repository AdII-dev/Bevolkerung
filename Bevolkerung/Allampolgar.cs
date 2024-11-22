using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bevolkerung;

namespace Bevolkerung
{
    class Allampolgar
    {
        public int Id { get; set; }
        public string Nem { get; set; }
        public int SzuletesiEv { get; set; }
        public int Suly { get; set; }
        public int Magassag { get; set; }
        public bool Dohanyzik { get; set; }
        public string Nemzetiseg { get; set; }
        public string Nepcsoport { get; set; }
        public string Tartomany { get; set; }
        public int NettoJovedelem { get; set; }
        public string IskolaiVegzettseg { get; set; }
        public string PolitikaiNezet { get; set; }
        public bool AktivSzavazo { get; set; }
        public int SorFogyasztasEvente { get; set; }
        public int KrumpliFogyasztasEvente { get; set; }
        public override string ToString() =>
            $"{Id} {Nem} {SzuletesiEv} {Suly} {Magassag} {(Dohanyzik ? "igen" : "nem")} {Nemzetiseg} {Nepcsoport} {Tartomany} {NettoJovedelem} {IskolaiVegzettseg} {PolitikaiNezet} {(AktivSzavazo ? "igen" : "nem")} {(SorFogyasztasEvente == -1 ? "NA" : SorFogyasztasEvente)} {(KrumpliFogyasztasEvente == -1 ? "NA" : KrumpliFogyasztasEvente)}";

        public Allampolgar(string r)
        {
            var v = r.Split(';');
            Id = int.Parse(v[0]);
            Nem = v[1];
            SzuletesiEv = int.Parse(v[2]);
            Suly = int.Parse(v[3]);
            Magassag = int.Parse(v[4]);
            Dohanyzik = v[5] == "igen";
            Nemzetiseg = v[6];
            if (v[7] == string.Empty) Nepcsoport = "NA";
            Nepcsoport = v[7];
            Tartomany = v[8];
            NettoJovedelem = int.Parse(v[9]);
            if (v[10] == string.Empty) IskolaiVegzettseg = "NA";
            IskolaiVegzettseg = v[10];
            PolitikaiNezet = v[11];
            AktivSzavazo = v[12] == "igen";
            if (v[13] == "NA") SorFogyasztasEvente = -1;
            else SorFogyasztasEvente = int.Parse(v[13]);
            if (v[14] == "NA") KrumpliFogyasztasEvente = -1;
            else KrumpliFogyasztasEvente = int.Parse(v[14]);
        }


    }
}
