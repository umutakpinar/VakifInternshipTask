# VakifIntershipTask
1) Uygulama, kullanıcı tarafından seçilen klasör altında bulunan, ismi DTO ile başlayan .cs dosyarını bulur.


2) Bu dosyalar içerisindeki DTO classlarında bulunan private access modifier'ına sahip tüm satırları bulur ve bir List<String> içerisinde tutar.


3) Daha sonra bu satırlar içeriisndeki field'ların isimlerini alır


4) Bu DTO class'ı ieçriside bulunan Copy() metodu içerisinde kullanılan property'lerin de isimlerini alır (Copy() metodu yoksa da çalışır)


5) Copy() metodu içerisinde bu propertylerin hangilerinin kullanılıp, hangilerinin kullanılmadığını analiz eder.


6) Analiz sonucunda kullanıcıya yeni bir ekran göstererek seçilen klasörde kaç tane DTO dosyası olduğunu, kaç tanesinde eksik propertyler olduğunu, ve bu propertylerin isimlerini kullanıcıya gösterir. Kullanıcı isterse bu sonucu bir .txt çıktısı olarak da alabilir.


