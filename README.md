# CancellationTokenExample

Hiç kullandığınız bir uygulamada yanlış bir iş yapıp ardından işlem devam ederken yapılan işlem iptal olsun diye uygulamayı kapattığınız oldu mu? 
Peki uygulamayı kapatınca işlem iptal mi oldu yoksa tamamlandı mı? Veya API ye atılan bir istekte isteğin yanıtı uzun sürdüğünde isteği beklemek yerine iptal etmek isteyebiliriz. 
Peki atılan isteği nasıl iptal edebiliriz?
Başlıkta da gördüğünüz teknolojiyi kullanmıyorsanız ve apiye isteğiniz gittikten sonra uygulamayı kapatsanız dahi api isteği aldığı için işlemine devam edecektir 
veya isteği iptal edemediğimiz için mecburen bekleyeceğiz.
İşte bu noktada Cancellation Token bizim imdadımıza yetişiyor.

![image](https://user-images.githubusercontent.com/12509659/156037764-a93fc3d5-7221-4cab-8593-6ba8bc47ded4.png)

## ThrowIfCancellationRequested
![image](https://cdn-images-1.medium.com/max/800/1*esDnGruq1P0SV40EwM-IOQ.png)

### Medium'da daha detaylı okumak için [tıklayınız.](https://medium.com/@nihatclk/cancellation-token-kullan%C4%B1m%C4%B1-a033ff19e118)
