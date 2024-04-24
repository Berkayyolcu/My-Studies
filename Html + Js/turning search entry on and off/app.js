
  /*QuerySelector () yöntemi, CSS seçicilere dayalı olarak DOM'dan
    html elemanlarını seçmenize izin veren 
    iki modern JavaScript yönteminden biridir.*/
  const search = document.querySelector('.search')
  const input = document.querySelector('.input')
  const btn = document.querySelector('.btn')

  /*addEventListener yöntemi, bir kullanıcı bir düğmeyi
    tıkladığında olduğu gibi, belirli bir olay gerçekleştiğinde
    çağrılacak işlevleri ayarlamanıza olanak tanır.*/
    btn.addEventListener('click', () => {
    	search.classList.toggle('active')

  /*classList bir elementin stil sınıflarını tutan bir nesnedir
    ve bu nesnenin add metodu ile elemente yeni sınıflar eklenebilir.
    add metodu parametre olarak eklenecek sitil sınıfının adını alır.
    Kaç adet css sınıfı eklenecek ise hepsi virgül 
    ile ayrılarak aynı anda verilebilir.*/

   /* toggle() metodunu kullanarak, hide() ve show() 
   metotları arasında geçişler sağlayabilirsiniz;*/

   input.focus()
})