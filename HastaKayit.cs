using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donem_odevi
{
    public  class HastaKayit
    {
      
        public int HastaTc { get; set; }
        public string HastaAdi { get; set; }
        public string HastaSoyadi { get; set; }
        public string hastaBabaAd { get; set; }
        public string HastaCinsiyet { get; set; }
        public string HastaDogumIl { get; set; }
        public string HastaDogumIlce { get; set; }
        public string HastaDogumYil { get; set; }
        public string HastaEvAdres { get; set; }
        public string HastaIsAdres { get; set; }
        public string HastaYakinAdres { get; set; }
        public string HastaTelefonEv { get; set; }
        public string HastaTelefonIs { get; set; }
        public string HastaTelefonCep { get; set; }
        public string HastaTelefonDiger { get; set; }
        public string HastaKimlikTuru { get; set; }
        public string HastaSeriNo { get; set; }

        public string HastaKayitIli { get; set; }
        public string HastaKayitliIlce { get; set; }

        public string HastaKimlikMahalle { get; set; }

        public string HastaKimlikCildNo { get; set; }

        public string HastaAileSiraNo { get; set; }
        public string HastaSiraNo { get; set; }

        public string HastaKimlikVerildigiYer { get; set; }
        
        public string HastaKimlikVerilisTarihi { get; set; }
        
        public string HastaUyruk { get; set; }
        public string HastaMedeniHali { get; set; }

        public string HastaKanGrubu { get; set; }
        public string HastaOgrenimDurumu { get; set; }

        public string HastaCalismaDurumu { get; set; }

        public string HastaMeslegi { get; set; }

        public string HastaMail{ get; set; }

        public string HastaAcilYakiniAd { get; set; }

        public string HastaAcilYakiniTel { get; set; }
        public string HastaKayitTarihi { get; set; }

        public string HastaBasvuruBolumu { get; set; }

        public string HastaDoktor { get; set; }

        public string HastaVezneIslemi { get; set; }

        public HastaKayit(int hastaTc, String hastaAdi, String hastaSoyadi, String hastaBabaAd, String hastaCinsiyet,
          String hastaDogumIl, String hastaDogumIlce, String hastaDogumYil, String hastaEvAdres, string hastaIsAdres, String hastaYakinAdres,
          string hastaTelefonEv, string hastaTelefonIs, string hastaTelefonCep, string hastaTelefonDiger, string hastaKimlikTuru, 
          String hastaSeriNo, string hastaKayitIl, string hastaKayitIlce, string hastaKimlikMahalle, string hastaKimlikCildNo,
          string hastaAileSiraNo, string hastaSiraNo, string hastaKimlikVerildigiYer, string hastaKimlikVerilisTarihi, string hastaUyruk , 
          string hastaMedeniHali , string hastaKanGrubu , string hastaOgrenimDurumu , string hastaCalismaDurumu, string hastaMeslegi ,string hastaMail , 
          string hastaAcilYakiniAd , string hastaAcilYakiniTel,string hastaKayitTarihi, string hastaBasvuruBolumu,
          string hastaDoktor, string hastaVezneIslemi)

        {

            this.HastaTc = hastaTc;
            this.HastaAdi=hastaAdi;
            this.HastaSoyadi = hastaSoyadi;
            this.hastaBabaAd = hastaBabaAd;
            this.HastaCinsiyet = hastaCinsiyet;
            this.HastaDogumIl = hastaDogumIl;
            this.HastaDogumIlce = hastaDogumIlce;
            this.HastaDogumYil = hastaDogumYil;
            this.HastaEvAdres = hastaEvAdres;
            this.HastaIsAdres = hastaIsAdres;
            this.HastaYakinAdres = hastaYakinAdres;
            this.HastaTelefonEv = hastaTelefonEv;
            this.HastaTelefonIs = hastaTelefonIs;
            this.HastaTelefonCep = hastaTelefonCep;
            this.HastaTelefonDiger = hastaTelefonDiger;
            this.HastaKimlikTuru = hastaKimlikTuru;
            this.HastaSeriNo = hastaSeriNo;
            this.HastaKayitIli = hastaKayitIl;
            this.HastaKayitliIlce = hastaKayitIlce;
            this.HastaKimlikMahalle = hastaKimlikMahalle;
            this.HastaKimlikCildNo = hastaKimlikCildNo;
            this.HastaAileSiraNo = hastaAileSiraNo;
            this.HastaSiraNo = hastaSiraNo;
            this.HastaKimlikVerildigiYer = hastaKimlikVerildigiYer;
            this.HastaKimlikVerilisTarihi = hastaKimlikVerilisTarihi;
            this.HastaUyruk = hastaUyruk;
            this.HastaMedeniHali = hastaMedeniHali;
            this.HastaKanGrubu = hastaKanGrubu;
            this.HastaOgrenimDurumu = hastaOgrenimDurumu;
            this.HastaCalismaDurumu = hastaCalismaDurumu;
            this.HastaMeslegi = hastaMeslegi;
            this.HastaMail = hastaMail;
            this.HastaAcilYakiniAd=hastaAcilYakiniAd;
            this.HastaAcilYakiniTel = hastaAcilYakiniTel;
            this.HastaKayitTarihi = hastaKayitTarihi;
            this.HastaBasvuruBolumu = hastaBasvuruBolumu;
            this.HastaDoktor = hastaDoktor;
            this.HastaVezneIslemi = hastaVezneIslemi;



        }
        
    }
}
