# VakifIntershipTask
Uygulama, kullanıcı tarafından seçilen klasör altında bulunan, ismi DTO ile başlayan .cs dosyarını bulur.
Bu dosyalar içerisindeki DTO classlarında bulunan private access modifier'ına sahip tüm satırların bulur.
Daha sonra bu satırlar içeriisndeki field'ların isimlerini alır
Bu DTO class'ı ieçriside bulunan Copy() metodu içerisinde kullanılan property'lerin de isimlerini alır (Copy() metodu oluşturulmamışsa da çalışır)
Field'ların her birinin ilk harfini büyüterek, Copy() metodu içerisinde bu propertylerin hangilerinin kullanılıp, hangilerinin kullanılmadığını analiz eder. 
(Eğer bir private field'ın property'si oluşturulmamışsa Copy() içerisinde de kullanılamayacağından property'leri kontrol etmiyor. Field'ların ilk harfleirni büyüterek Copy() içerisinde kullanılanlarla kıyaslıyor.)
Analiz sonucunda kullanıcıya yeni bir ekran göstererek seçilen klasörde kaç tane DTO dosyası olduğunu, kaç tanesinde eksik propertyler olduğunu, ve bu propertylerin isimlerini kullanıcıya gösterir.
Kullanıcı isterse bu sonucu bir .txt çıktısı olarak da alabilir.


