# OYUNPROGRAMLAMA

   Bu projede aşina olduğumuz Doodle Jump oyununun oynanış biçimini aynı tutarak yeniden tasarladık. Bu oyunda amaç , açılan oyun ekranında karakterin otomatik zıplama özelliği ile yere düşmeden kullanıcı kontrolünde platformlar üzerinde ilerlemesidir . Karakterin kontrolü "A-D" tuşları ile sağlanmış olup , zıplama anında hareket ettiği yöne dönerek gerçekçi bir deneyim sağlanmaktadır. Başarıyla geçilen her platform başı 3 puan eklenmekte olup skor bilgisi oyunun üst orta kısmında kullanıcıya sunulmaktadır. Oyun esnasında ESC tuşuna basılarak oyun durdurulabilir ve tekrar aynı tuşla oyuna devam edilebilmektedir. Bir sonraki platforma başarılı bir geçiş sağlanamayıp karakter düşerse oyun biterek yeniden başlatılır. Bu durumda ise kullanıcı oyuna başladığı ilk ekrandan yeniden başlayacak olup aynı şekilde platformdan düşene kadar bu döngü devam ettirilir. 
   
   OYUN RESMİ
   
  ![image](https://user-images.githubusercontent.com/54940125/204642819-572fa0ee-81e6-4f5e-87b7-2c218cae3d36.png)
  ![image](https://user-images.githubusercontent.com/54940125/204643116-20585de0-fb5c-4d67-bfcd-a9ace4f661cc.png)




   OYUNDA BENİM GELİŞTİRDİĞİM SCRİPTLER
   
   
   İlk olarak unity de geliştirmek istediğimiz oyunun tasarımını yaptık. Ana karakter ve platform ögelerini oluşturdum . Destroy Scriptinde ekip arkadaşımla karşılıklı ilerleme kaydederek scripti tamamladım. Daha sonra karakterin ve platformun collider ve rigidbody değerlerini atayarak çarpışma , ağırlık gibi değerlerinin atanmasıyla karakterin hareketinin yatay eksende alınmasını ve "A-D" tuşları ile kontrolünün sağlayarak ilerleyebilmesi için gerekli kuvvet ve hız değerlerini karaktere vererek düzgün bir hareket sistemi olmasını sağlayan scripti ekip arkadaşım ile geliştirdim. ButonManager scriptini yazarak  esc tuşu ile eklenen resume ve pause ve özelliklerini geliştirdim. Erken tasarım aşamasında kararlaştırdığımız tasarımı Menu olarak oyuna aktardım. Butonlara gerekli ayarlamaları yaptım
   
   OYUNDA ARKADAŞIMIN GELİŞTİRDİĞİ SCRİPTLER
   
   
   Ekip arkadaşım Canvas kullanarak bu oyunun geliştirilmesinde görev aldı. Buna ek olarak Bounce ve Destroy scriptlerini geliştirmiş olup karakterin atladığı platformların random bir şekilde oluşturulmasını sağlayıp her atlayışta dönüş yönü esas alınarak karakteri sağ ve sol görünümüne göre ayarladı. Karakter için oluşturulmuş olan bütün özelliklerin arasındaki bağlantıların sorunsuz çalıştığına emin olarak projeyi sonlandırdı.
