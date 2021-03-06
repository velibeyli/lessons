using ProjectAsTurbo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAsTurbo
{
    public class VirtualDatabase
    {
        //All Brands list
        public List<string> Brands = new List<string>() 
        {
            "Abarth",
            "Acura",
            "Alfa Romeo",
            "Aprilia",
            "Arctic Cat",
            "Aston Martin",
            "ATV",
            "Audi",
            "Avia",
            "Baic",
            "Bajaj",
            "Bentley",
            "Bestune",
            "BMW",
            "BMW Alpina",
            "Brilliance",
            "Buick",
            "BYD",
            "Cadillac",
            "Changan",
            "Chery",
            "Chevrolet",
            "Chrysler",
            "Citroen",
            "Dacia",
            "Daewoo",
            "DAF",
            "Daihatsu",
            "Dayun",
            "Dnepr",
            "Dodge",
            "DongFeng",
            "Ducati",
            "FAW",
            "Fiat",
            "Ford",
            "Foton",
            "GAC",
            "GAZ",
            "Geely",
            "Genesis",
            "GMC",
            "Great Wall",
            "Haima",
            "Haojue",
            "Harley-Davidson",
            "Haval",
            "Honda",
            "Hongqi",
            "HOWO",
            "Hummer",
            "Hyundai",
            "IJ",
            "Infiniti",
            "Iran Khodro",
            "Isuzu",
            "Iveco",
            "JAC",
            "Jaguar",
            "Jawa",
            "Jeep",
            "Jetour",
            "Jianshe",
            "Jinbei",
            "Jonway",
            "KamAz",
            "KAvZ",
            "Kawasaki",
            "Kayo",
            "Keeway",
            "Khazar",
            "Kia",
            "KrAZ",
            "KTM",
            "Kuba",
            "LADA (VAZ)",
            "Lamborghini",
            "Land Rover",
            "Lexus",
            "Lifan",
            "Lincoln",
            "LuAz",
            "MAN",
            "Maserati",
            "MAZ",
            "Mazda",
            "Mercedes",
            "Mercedes-Maybach",
            "MG",
            "Mini",
            "Minsk",
            "Mitsubishi",
            "Moskvich",
            "Muravey",
            "Nama",
            "Neptun",
            "Nissan",
            "NIU",
            "Opel",
            "Otocar",
            "PAZ",
            "Peugeot",
            "Polaris",
            "Porsche",
            "Proton",
            "RAF",
            "Ravon",
            "Renault",
            "RKS",
            "Rolls-Royce",
            "Rover",
            "Saipa",
            "Scania",
            "SEAT",
            "Setra",
            "Shacman",
            "Shaolin",
            "Skoda",
            "Smart",
            "Ssang Yong",
            "Subaru",
            "Suzuki",
            "SYM",
            "Tata",
            "Temsa",
            "Tesla",
            "Tofas",
            "Toyota",
            "Tufan",
            "UAZ",
            "Ural",
            "Vespa",
            "Volkswagen",
            "Volvo",
            "Yadea",
            "Yamaha",
            "ZAZ",
            "ZIL",
            "Zongshen",
            "Zontes",
            "ZX Auto"
        };
        //BrandList end

        //All Cities list
        public List<string> Cities = new List<string>()
        {
            "Ağcabədi","Ağdam","Ağdaş","Ağstafa","Ağsu","Astara","Bakı","Balakən","Beyləqan","Bərdə",
            "Biləsuvar","Cəbrayıl","Cəlilabad","Daşkəsən","Dəliməmmədli","Füzuli","Gədəbəy","Gəncə",
            "Goranboy","Göyçay","Göygöl","Göytəpə","Hacıqabul","Horadiz","İmişli","İsmayıllı",
            "Kürdəmir","Lerik","Lənkəran","Liman","Masallı","Mingəçevir","Naftalan","Naxçıvan",
            "Neftçala","Oğuz","Ordubad","Qax","Qazax","Qəbələ","Qobustan","Quba","Qusar","Saatlı",
            "Sabirabad","Şabran","Salyan","Şamaxı","Samux","Şəki","Şəmkir","Şərur","Şirvan","Siyəzən",
            "Sumqayıt","Tərtər","Tovuz","Ucar","Xaçmaz","Xırdalan","Xızı","Xudat","Yardımlı",
            "Yevlax","Zaqatala","Zərdab"
        };
        //City list end

        //All Colors
        public List<string> AllColor = new List<string>()
        {
            "Qara", "Yaş Asfalt", "Boz", "Gümüşü", "Ağ", "Bej", "Tünd qırmızı", "Qırmızı",
            "Çəhrayı", "Narıncı", "Qızılı", "Sarı", "Yaşıl", "Mavi", "Göy", "Bənövşəyi", "Qəhvəyi"
        };
        //Colors end
        public List<Car> Car = new List<Car>();
        //public List<Car> GetCar(int count)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Car car = new Car();
        //        car.Photo = 
        //    }
        //}
    }
}
