
/*getElementById Metodu
Web sayfasındaki html etiketlerine ulaşmak için en
 çok kullanılan metotlardan biridir. Ulaşılmak istenen html 
 nesnesinin id'si belirtilerek, ilgili elemana ulaşmamızı sağlar.*/
 const insert = document.getElementById('insert')

/*JavaScript addEventListener yöntemi, bir kullanıcı bir 
düğmeyi tıkladığında olduğu gibi, belirli bir olay gerçekleştiğinde 
çağrılacak işlevleri ayarlamanıza olanak tanır. Olaylar, kullanıcı 
veya tarayıcı bir sayfayı manipüle ettiğinde gerçekleşen eylemlerdir.*/
window.addEventListener('keydown', (event) => {
  //console.log(e)

  /*JavaScript ile Html DOM üzerindeki bir öğenin 
  içeriğini Html kodları ile birlikte alabilir veya seçtiğimiz 
  Html öğesinin içerisine Html kodları ekleyebiliriz. Bunun için
  JavaScript'deki innerHtml özelliğini kullanıyoruz.*/
  insert.innerHTML = `
  <div class="key">
  ${event.key === ' ' ? 'Space' : event.key}
  <small>event.key</small>
  </div>
  <div class="key">
  ${event.keyCode}
  <small>event.keyCode</small>
  </div>
  <div class="key">
  ${event.code}
  <small>event.code</small>
  </div>
  `
})