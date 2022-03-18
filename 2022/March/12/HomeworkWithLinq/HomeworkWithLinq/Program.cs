using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkWithLinq.Enums;

namespace HomeworkWithLinq
{
    public delegate void RunAnyMethod();
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework1
            /*
             Homework 1:
             public delegate void RunAnyMethod();

             public static void Add(){
                 Console.WriteLine("Add method");
             }

             public static void Edit(){
                 Console.WriteLine("Add method");
             }

             public static void Delete(){
                 Console.WriteLine("Add method");
             }

             Yuxarıda 1 delegate'iniz var və 3 dənə də standart adi method. Elə etməlisiniz ki, məsələn myDelegate adında bir dəyişəniniz olsun və myDelegate dəyişənini
             method kimi istifadə edə biləsiniz. Yəni myDelegate() yazanda bir method işləmiş olsun. Bu qayda da sadəcə 1 dəyişən sayəsində Add, Edit, Delete methodlarını işlətməlisiz.
             Bunu etmək üçün biraz araşdırmalı olacaqsız.
             */

            var myDelegate = new RunAnyMethod(Add);
            myDelegate += Edit;
            myDelegate += Delete;

            myDelegate.Invoke();

            #endregion

            #region Homework2

            /* 
             Bir Car class'ınız olsun. (Property'ləri: Şəhər(satıldığı), Marka, Model, Buraxılış ili, Rəngi, Mühərrik Həcmi, At Gücü, Kilometrajı, Sürətlər Qutusunun tipi, Qiyməti)
             Nümunə data:
             Şəhər: Bakı
             Marka: Lexus
             Model: GX460
             Buraxılış ili: 2021
             Rəngi: Black(Enum olacaq və 10-15 dənə rəng olsun Enum'da)
             Mühərrik Həcmi: 4500
             At Gücü: 296
             Kilometrajı: 15777
             Sürətlər Qutusunun tipi: Automatic (Enum olacaq dəyərləri də Automatic, Manual, Robot)
             Qiyməti: 200.000

            Aşağıdakı sorğuları yazın:
             1. Markası Mercedes olub, mühərrik həcmi 4200'dən az olan və ya bərabər olan, Bakıda satılan.
             2. Bakıda satılmayan, buraxılış ili 2015-ci il daxil olmaqla 2020-ci ilə qədər olan (2020 də daxildir buna)
             3. Kilometrajı 0 olan və Modelində "ML" sözü olan
             4. Sürətlər qutusu avtomatik olan və qiyməti 15.000-17.500 arasında olan
             5. Rəngi Red, Black olmayan, mühərrik həcmi 2000-4000 arasında olan, sürətlər qutusu Robot olmayan, buraxılış ili 2010-dan köhnə olmayan.
             6. Ya markası Lexus olub, qiyməti 30.000-ə qədər olan ya da markası Mercedes olub qiyməti 45.000-ə qədər olan.
            */

            Car car1 = new Car("Baki", "Lexus", "GX460", 2021, ColorEnum.Black, 4500, 296, 15777, TransmissionEnum.Automatic, 200000);
            Car car2 = new Car("Baki", "Mercedes", "ML", 2012, ColorEnum.White, 3500, 250, 60000, TransmissionEnum.Robotic, 45000);
            Car car3 = new Car("Lenkeran", "Mercedes", "Vito", 2016, ColorEnum.Blue, 2400, 180, 90000, TransmissionEnum.Manual, 30000);
            Car car4 = new Car("Quba", "Hyundai", "Getz", 2022, ColorEnum.Red, 1800, 140, 0, TransmissionEnum.Automatic, 50000);
            Car car5 = new Car("Gence", "Hyundai", "sonata", 2009, ColorEnum.Gray, 2000, 170, 214000, TransmissionEnum.Automatic, 16500);

            List<Car> carList = new List<Car>();
            carList.Add(car1);
            carList.Add(car2);
            carList.Add(car3);
            carList.Add(car4);
            carList.Add(car5);

            var query1 = carList.Where(m => m.Brand == "Mercedes" && m.EngineVolume <= 4200 && m.City == "Baki").ToList();
            var query2 = carList.Where(m => m.City != "Baki" && m.Year >= 2015 && m.Year <= 2020).ToList();
            var query3 = carList.Where(m => m.Mileage == 0 && m.Model.ToLower().Contains("ML")).ToList();
            var query4 = carList.Where(m => m.Transmission == TransmissionEnum.Automatic && m.Price >= 15000 && m.Price <= 17000).ToList();
            var query5 = carList.Where(m => m.Color != ColorEnum.Red && m.Color != ColorEnum.Black && m.EngineVolume >= 2000 && m.EngineVolume <= 4000 && m.Transmission != TransmissionEnum.Robotic && m.Year >= 2010).ToList();
            var query6 = carList.Where(m => (m.Brand == "Lexus" && m.Price <= 30000) || (m.Brand == "Mercedes" && m.Price <= 45000)).ToList();

            #endregion

            #region Homework3
            /*
             Bir dənə int array'ında 1-1000 arası rəqəmləriniz olsun (for ilə edin).
             1. Array'dan cüt rəqəmləri sorğu ilə götürün.
             2. Arrayda 400-dən böyük, 550-yə bərabər və ya kiçik olan, tək rəqəmləri götürün.
             */

            int[] numbers = new int[1000];

            for (int i = 0; i < 1000; i++)
            {
                numbers[i] = i + 1;
            }

            var result = numbers.Where(m => m % 2 == 0);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Homework4

            /*
             Bir dənə String List'iniz olsun (names) və FakeData ilə 1000 dənə Name əlavə edin.
             Sonra həmin list'dən adı 5 simvol və ya daha uzun olan adları silin. Bunu etmək üçün Remove və ya RemoveAll method'larını araşdırın və elə edin.
             */

            List<string> names = new List<string>();
            string name;

            for (int i = 0; i < 1000; i++)
            {
                name = FakeData.NameData.GetFirstName();
                names.Add(name);
            }

            names.RemoveAll(m => m.Length >= 5);

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }


            #endregion

            #region Homework5
            /*
             Name, Surname, Fullname adlı property'ləri olan Person adlı bir class'ınız olsun. FakeData ilə Person tipində bir listə 1000 nəfər əlavə edin.
             Əlavə edəndə Name və Surname property'lərini set edin amma fullname boş qalsın. Artıq əlinizdə 1000 nəfərin Ad və Soyadı olan bir list hazır olduqdan
             sonra Linq istifadə edərək Ad və Soyad'dan Fullname'i set edin.
             END
             */

            Console.Clear();

            List<Person> people = new List<Person>();

            Person person = new Person();

            for (int i = 0; i < 1000; i++)
            {
                person.Name = FakeData.NameData.GetFirstName();
                person.Surname = FakeData.NameData.GetSurname();

                people.Add(person);

                person.Fullname = person.Name + " " + person.Surname;
                Console.WriteLine(person.Fullname);

            }

            //VirtualDatabase db = new VirtualDatabase();
            //db.GetFullname();

            #endregion

            Console.ReadLine();
        }
        public static void Add()
        {
            Console.WriteLine("Add method");
        }

        public static void Edit()
        {
            Console.WriteLine("Edit method");
        }

        public static void Delete()
        {
            Console.WriteLine("Delete method");
        }

    }
}
